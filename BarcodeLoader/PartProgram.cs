using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace BarcodeLoader
{
    public class PartProgram : IEquatable<PartProgram> 
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

        public static bool operator ==(PartProgram lhs, PartProgram rhs)
        {
            if (Object.ReferenceEquals(lhs, null))
            {
                return Object.ReferenceEquals(rhs, null);
            }
            else
            {
                return lhs.Equals(rhs);
            }
        }

        public static bool operator !=(PartProgram lhs, PartProgram rhs)
        {
            return !(lhs == rhs);
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

        /// <summary>Internal constructor
        /// </summary>
        internal PartProgram()
        {
        }

        /// <summary>Answers an <see cref="XElement"/> object based on this instance, suitable for a configuration file.
        /// </summary>
        /// <returns>An <see cref="XElement"/> based on this instance.</returns>
        public XElement ToXElement()
        {
            XElement ret = new XElement("PartProgram");

            ret.Add(new XAttribute("barcode", _barcode));
            ret.Add(new XAttribute("programFilename", _programFilename));

            if (_programPath != null) ret.Add(new XAttribute("programPath", _programPath));
            if (_setupFilename != null) ret.Add(new XAttribute("setupFilename", _setupFilename));
            if (_setupPath != null) ret.Add(new XAttribute("setupPath", _setupPath));
            if (_thumbnailFilename != null) ret.Add(new XAttribute("thumbnailFilename", _thumbnailFilename));
            if (_thumbnailPath != null) ret.Add(new XAttribute("thumbnailPath", _thumbnailPath));
            if (_scheduleProgram) ret.Add(new XAttribute("schedule", _scheduleProgram));

            if (_description != null) ret.Add(new XElement("description", _description));

            return ret;
        }

        /// <summary>Answers the part program filename.
        /// </summary>
        public string ProgramFilename { get { return _programFilename; } set { _programFilename = value; } }

        /// <summary>Answers the part program file path.
        /// </summary>
        public string ProgramPath { get { return _programPath; } set { _programPath = value; } }

        /// <summary>Answers the setup video filename.
        /// </summary>
        public string SetupFilename { get { return _setupFilename; } set { _setupFilename = value; } }

        /// <summary>Answers the setup video file path.
        /// </summary>
        public string SetupPath { get { return _setupPath; } set { _setupPath = value; } }

        /// <summary>Answers the part program thumbnail image filename.
        /// </summary>
        public string ThumbnailFilename { get { return _thumbnailFilename; } set { _thumbnailFilename = value; } }

        /// <summary>Answers the part program thumbnail image file path.
        /// </summary>
        public string ThumbnailPath { get { return _thumbnailPath; } set { _thumbnailPath = value; } }

        /// <summary>Answers the description of the part program.
        /// </summary>
        public string Description { get { return _description; } set { _description = value; } }

        /// <summary>Answers the barcode text to match.
        /// </summary>
        public string Barcode { get { return _barcode; } set { _barcode = value; } }

        /// <summary>Answers whether this is a schedule program.
        /// </summary>
        public bool ScheduleProgram { get { return _scheduleProgram; } set { _scheduleProgram = value; } }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as PartProgram);
        }

        public bool Equals(PartProgram other)
        {
            if (other == null) return false;

            return this.Barcode == other.Barcode
                && this.ProgramFilename == other.ProgramFilename
                && this.ProgramPath == other.ProgramPath
                && this.ThumbnailFilename == other.ThumbnailFilename
                && this.ThumbnailPath == other.ThumbnailPath
                && this.SetupFilename == other.SetupFilename
                && this.SetupPath == other.SetupPath
                && this.Description == other.Description
                && this.ScheduleProgram == other.ScheduleProgram
            ;
        }

        public override int GetHashCode()
        {
            return (this.Barcode ?? "").GetHashCode()
                ^ (this.ProgramFilename ?? "").GetHashCode()
                ^ (this.ProgramPath ?? "").GetHashCode()
                ^ (this.ThumbnailFilename ?? "").GetHashCode()
                ^ (this.ThumbnailPath ?? "").GetHashCode()
                ^ (this.SetupFilename ?? "").GetHashCode()
                ^ (this.SetupPath ?? "").GetHashCode()
                ^ (this.Description ?? "").GetHashCode()
                ^ (this.ScheduleProgram).GetHashCode()
            ;
        }

        #endregion



    }
}
