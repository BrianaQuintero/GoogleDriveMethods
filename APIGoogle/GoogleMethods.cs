using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIGoogle
{
    class GoogleMethods
    {
        GoogleCredential _credential = null;
        DriveService _driveService = new DriveService();
        CalendarService _calendarService = new CalendarService();

        public GoogleMethods(string credentialsKey)
        {
            GoogleCredential credential = null;
            if (!string.IsNullOrEmpty(credentialsKey))
            {
                credential = GoogleCredential.FromFile(credentialsKey).
                CreateScoped(new[] {
                    DriveService.ScopeConstants.Drive,
                     CalendarService.ScopeConstants.Calendar
            });
            }
            _credential = credential;
        }

        public DriveService startDriveService()
        {
            try
            {
                var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = _credential
                });

                return service;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error method startDriveService():" + ex.ToString());
                return null;
            }
        }

        public CalendarService startCalendarService()
        {
            try
            {
                var service = new CalendarService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = _credential,
                  //  ApplicationName = "Test Calendar Reader",
                });

                return service;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error method startCalendarService():" + ex.ToString());
                return null;
            }
        }

        public async Task<List<GoogleDriveFiles>> getFilesFromGoogleDrive(string fileDriveID)
        {
            List<GoogleDriveFiles> getFileList = new List<GoogleDriveFiles>();
            var request = _driveService.Files.List();
            request.Q = "parents in '" + fileDriveID + "'";
            var results = await request.ExecuteAsync();

            foreach (var driveFiles in results.Files)
            {
                GoogleDriveFiles fileInfo = new GoogleDriveFiles(
                    driveFiles.Name,
                    driveFiles.MimeType,
                    driveFiles.Id,
                    string.IsNullOrEmpty(driveFiles.DriveId)? string.Empty : driveFiles.DriveId
                    );
                getFileList.Add(fileInfo);
            }

            MessageBox.Show(String.Join("\n", getFileList.Select(x => x.fileName)));
            return getFileList;

        }
        public string getMimeType(string path)
        {
            string typeFile = string.Empty;
            switch (Path.GetExtension(path))
            {
                //case ".txt":
                //    typeFile= "text/plain";
                //    break;
                case ".docx":
                    typeFile = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                    break;
                case ".pdf":
                    typeFile = "application/pdf";
                    break;
                case ".zip":
                    typeFile = "application/zip";
                    break;
                case ".xlsx":
                    typeFile = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    break;
                case ".pptx":
                    typeFile = "application/vnd.openxmlformats-officedocument.presentationml.presentation";
                    break;
                case ".jpg":
                    typeFile = "image/jpeg";
                    break;
                case ".png":
                    typeFile = "image/png";
                    break;
                case ".json":
                    typeFile = "application/vnd.google-apps.script+json";
                    break;
                default:
                    typeFile= "text/plain";
                    break;
            }
            return typeFile;

        }
        public async void saveLocalFileToGoogleDriveFolder(string fileDriveID, string newFileName, string localFilePath)
        {
            List<GoogleDriveFiles> getFileList  = await getFilesFromGoogleDrive(fileDriveID);

            if (!getFileList.Select(x => x.fileName).ToList().Contains(newFileName))
            {
                var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = newFileName,
                    Parents = new List<string>() { fileDriveID }
                };

                await using (var fsSource = new FileStream(localFilePath, FileMode.Open, FileAccess.Read))
                {
                    var request = _driveService.Files.Create(fileMetadata, fsSource, getMimeType(localFilePath));
                    request.Fields = "*";
                    var results = await request.UploadAsync(CancellationToken.None);

                    if (results.Status == Google.Apis.Upload.UploadStatus.Failed)
                    {
                        MessageBox.Show(results.Exception.Message);
                    }
                }

            }



        }
        public async void saveGoogleDriveFileToLocal(string fileDriveID, string specificFileName, string localFilePath)
        { 
            List<GoogleDriveFiles> getFileList = await getFilesFromGoogleDrive(fileDriveID);

            foreach (var fileInfo in getFileList)
            {
                if (fileInfo.fileType != "application/vnd.google-apps.folder")
                {
                    if (string.IsNullOrEmpty(specificFileName) || fileInfo.fileName.Contains(specificFileName))
                    {
                        var getRequest = _driveService.Files.Get(fileInfo.fileID);
                        await using var fileStream = new FileStream(localFilePath + fileInfo.fileName, FileMode.Create, FileAccess.Write);
                        await getRequest.DownloadAsync(fileStream);
                    }
                }
                else
                {
                    string newPath = CreateFolder(fileInfo.fileName, localFilePath);
                    saveGoogleDriveFileToLocal(fileInfo.fileID, specificFileName, newPath);
                }
            }
            
        }

        public string CreateFolder(string nameFolder,string path)
        {
            string newPath= path + nameFolder;
            if (!System.IO.Directory.Exists(newPath))
            {
                Directory.CreateDirectory(newPath);
            }
            return newPath+"\\";
        }
        public void useGoogleDriveMethods(bool ToUpload, string fileDriveID, string specificFileName, string filePath)
        {
            _driveService = startDriveService();
            if (ToUpload)
            {
                saveLocalFileToGoogleDriveFolder(fileDriveID, specificFileName, filePath);
            }
            else
            {
                saveGoogleDriveFileToLocal(fileDriveID, specificFileName, filePath);
            }

        }


        public void useGoogleCalendar(string calendarId, bool createEvent, 
            DateTime startDateTime,DateTime endDateTime, string summary = null, string description = null)
        {
            _calendarService = startCalendarService();
            if (createEvent)
            {
                CreateEventCalendar(calendarId, summary, description,startDateTime, endDateTime);
            }
            else
            {
                GetEvents(calendarId);
            }


        }
        
        public void GetEvents(string calendarId)
        {
            var query = _calendarService.Events.List(calendarId);

            var queryStart = DateTime.Now;
            var queryEnd = queryStart.AddYears(1);

            query.TimeMin = queryStart;
            query.TimeMax = queryEnd;

            var events2 = query.Execute().Items;

            var eventList = events2.Select(e => new Tuple<DateTime, string>(e.Start.DateTime.Value, e.Summary)).ToList();
            eventList.Sort((e1, e2) => e1.Item1.CompareTo(e2.Item1));

            string TotalEvent = string.Empty;
            foreach (var item in events2)
            {
                var startDate = item.Start;
                var title = item.Summary;
                var description = item.Description;
                var location = item.Location;

                if (string.IsNullOrEmpty(TotalEvent))
                {
                    TotalEvent = startDate.DateTime.ToString() + "," + title.ToString()+ "\n";
                }
                else
                {
                    TotalEvent = TotalEvent+startDate.DateTime.ToString() + "," + title.ToString() +"\n";
                }
            }
            MessageBox.Show(TotalEvent);
        }

        public void CreateEventCalendar(string calendarId,string summary,string description,DateTime startDateTime,DateTime endDatetime)
        {
            EventDateTime start = new EventDateTime();
            EventDateTime end = new EventDateTime();

            start.DateTime = startDateTime; //DateTime.Now;

                end.DateTime = endDatetime;// DateTime.Now.AddMinutes(10);


            //create event 
            var newEvent = new Event()
            {
                Summary = summary,
                Description = description,
                Start = start,
                End = end,
                // EventAttachment
            };

            Event recurringEvent = _calendarService.Events.Insert(newEvent, calendarId).Execute();

        }
    }

}

