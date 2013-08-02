using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace BarcodeLoader
{
    public class PartProgram
    {

        #region Static Interface

        /// <summary>Loads an array of part programs from a file.
        /// </summary>
        /// <param name="filename">The path to the configuration file.</param>
        /// <returns>An array of part programs.</returns>
        /// <remarks>If the file is not a valid XML file, this method will throw an exception. 
        /// If the file is XML, but does not contain proper configuration items, this method will return an empty array.</remarks>
        public static PartProgram[] FromFile(string filename)
        {
            List<PartProgram> ret = new List<PartProgram>();
            XDocument document = XDocument.Load(filename);
            foreach (XElement element in from XElement elem in document.Descendants() where elem.Name.LocalName == "PartProgram" select elem)
            {
                ret.Add(new PartProgram(element));
            }

            return ret.ToArray();
        }

        #endregion

        #region Implementation

        /// <summary>The filename of the part program.
        /// </summary>
        private string _programFilename;

        /// <summary>An optional file path to prepend to the program filename.
        /// </summary>
        private string _programPath;

        /// <summary>An optional filename for a setup video to play when the program is loaded.
        /// </summary>
        private string _setupFilename;

        /// <summary>An optional file path to prepend to the setup video filename.
        /// </summary>
        private string _setupPath;

        /// <summary>An optional filename for a thumbnail image to display for this part program.
        /// </summary>
        private string _thumbnailFilename;

        /// <summary>An optional file path to prepend to the thumbnail image filename.
        /// </summary>
        private string _thumbnailPath;

        /// <summary>An optional text description of the part program.
        /// </summary>
        private string _description;

        /// <summary>Indicates whether this is a schedule program.
        /// </summary>
        private bool _scheduleProgram;

        /// <summary>A barcode that maps to this part program.
        /// </summary>
        private string _barcode;

        #endregion

        #region Interface

        /// <summary>
        /// </summary>
        /// <param name="element">An <see cref="XElement"/> containing the part program information.</param>
        /// <remarks>
        /// TODO: document expected XElement format here.
        /// </remarks>
        public PartProgram(XElement element)
        {
            _programFilename = (string)element.Attribute("programFilename") ?? null;
            _programPath = (string)element.Attribute("programPath") ?? null;

            _setupFilename = (string)element.Attribute("setupFilename") ?? null;
            _setupPath = (string)element.Attribute("setupPath") ?? null;

            _thumbnailFilename = (string)element.Attribute("thumbnailFilename") ?? null;
            _thumbnailPath = (string)element.Attribute("thumbnailPath") ?? null;

            _barcode = (string)element.Attribute("barcode") ?? null;

            XElement descriptionElem = (from XElement elem in element.Descendants() where elem.Name.LocalName == "Description" select elem).FirstOrDefault();
            XAttribute descriptionAttr = element.Attribute("description");

            _description = (string)descriptionElem ?? (string)descriptionAttr;

            XAttribute scheduleAttr = element.Attribute("schedule");
            if(scheduleAttr==null)
            {
                _scheduleProgram = false;
            }
            else if(String.IsNullOrWhiteSpace(scheduleAttr.Value))
            {
                _scheduleProgram = false;
            }
            else
            {
                if(!bool.TryParse(scheduleAttr.Value, out _scheduleProgram)) _scheduleProgram = false;
            }



        }

        /// <summary>Answers the part program filename.
        /// </summary>
        public string ProgramFilename { get { return _programFilename; } }

        /// <summary>Answers the part program file path.
        /// </summary>
        public string ProgramPath { get { return _programPath; } }

        /// <summary>Answers the setup video filename.
        /// </summary>
        public string SetupFilename { get { return _setupFilename; } }

        /// <summary>Answers the setup video file path.
        /// </summary>
        public string SetupPath { get { return _setupPath; } }

        /// <summary>Answers the part program thumbnail image filename.
        /// </summary>
        public string ThumbnailFilename { get { return _thumbnailFilename; } }

        /// <summary>Answers the part program thumbnail image file path.
        /// </summary>
        public string ThumbnailPath { get { return _thumbnailPath; } }

        /// <summary>Answers the description of the part program.
        /// </summary>
        public string Description { get { return _description; } }

        /// <summary>Answers the barcode text to match.
        /// </summary>
        public string Barcode { get { return _barcode; } }

        /// <summary>Answers whether this is a schedule program.
        /// </summary>
        public bool ScheduleProgram { get { return _scheduleProgram; } }

        #endregion

    }
}
