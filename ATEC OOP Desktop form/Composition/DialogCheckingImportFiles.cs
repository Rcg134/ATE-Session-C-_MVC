using ATEC_OOP_Desktop_form.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATEC_OOP_Desktop_form.Composition
{
    internal class DialogCheckingImportFiles
    {
        private readonly import _imporitFiles;
        private readonly Export _exportFiles;


       
        public DialogCheckingImportFiles(import imporitFiles , Export exportFiles)
        {
            _imporitFiles = imporitFiles;
            _exportFiles = exportFiles;
        }

        public bool LocalImportFile(string filename)
        {
            bool isTrue = false;

            if (filename.Length != 0 )
            {
                isTrue = true;
                _imporitFiles.ImportFile(filename);
            }

            return isTrue;
        }

        public bool LocalExportFile(string data)
        {
            bool isTrue = false;

            if (data.Length > 0)
            {
                isTrue = true;
                _exportFiles.exportFile(data);
            }

            return isTrue;
        }

    }
}
