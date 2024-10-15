using System;
using System.Collections.Generic;
using System.Text;

namespace APIGoogle
{
    class GoogleDriveFiles
    {
        public string fileName { get; set; }
       public  string fileType { get; set; }
        public string fileID{ get; set; }
        public string driveID { get; set; }
        public GoogleDriveFiles(string _fileName, string _fileType, string _fileID, string _driveID)
        {
            fileName=_fileName;
            fileType = _fileType;
            fileID = _fileID;
            driveID = _driveID;

        }
    }
}
