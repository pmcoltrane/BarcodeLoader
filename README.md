# BarcodeLoader

BarcodeLoader is a simple application to load a part program on an Okuma P200 CNC, based on a scanned barcode.  The part programs are configurable through a configuration file, with a basic GUI editor included as well. 

## Prerequisites

* Okuma OSP-P200 or -P300 CNC
* Okuma THINC API installed on the CNC
* A barcode scanner (the keyboard may also be used)
* Visual Studio Express 2010 or higher

## Building

The solution was built in Visual Studio Express 2010 (C#), and should be buildable on that platform or later platforms. 

First, add a reference to the THINC Command API and Data API, for the specific THINC API version installed on your CNC.

Next, build the project. 

## Part Program Configuration

For part program configuration, select the "Configuration" tab. 

### Add a part program

To add a part program, click the "Add" button. This will display the add screen. 

Enter the barcode that will be used for the part program. 

Click the "Choose Program" button to select a part program. 

Optionally click the "Thumbnail Image" button to select an image. This image will be displayed in the UI when the part program is selected.

Optionally click the "Setup File" button to choose a setup file. This is a file that will be opened when the part program is loaded. Typically, this would be either a video or a document with additional setup instructions.

Enter a description of the part program for the operator. If this is a schedule program, check the "Schedule program" checkbox.

When everything is correct, click "Save".

### Remove a part program

Click the "Remove" button.

### Modify a part program

There is no GUI editing available for existing programs. Either remove the part program and re-add it with the appropriate changes, or modify the PartPrograms.xml file directly.

## Advanced Configuration

For advanced configuration, select the "Advanced" tab. 

"Automatically load a part program when selected" will automatically load the part program whenever the barcode has identified a single matching part program. This may cause undesirable behavior with slow barcode scanners, and is not recommended.

"Require matching case on barcode" will perform a case-sensitive match. This means that the strings "Abcde", "ABCDE", "abcde", and "AbCdE" would all be considered different. If this is not selected, then case-insensitive comparison is performed, and all of those strings would be considered identical.

The set of radio buttons selects what to do when a part program has a setup file specified. The options are:
* Run the file automatically
* Prompt whether to run the file
* Do not run the file

## Usage

Make sure the "Scan Barcode" tab is selected, and that the text box is active. Scan a barcode or type the barcode in with the keyboard.

If the barcode matches a part program, that part program's information will be displayed, and you can load the part program with the "Load" button. Otherwise, the application will display either a "no matching programs" or "multiple matching programs" message accordingly.

## Future changes

* Admin lockout for configuration; require an admin password to change configuration.
* Persist advanced configuration so that the last configuration is reloaded at startup.
* Testing on OSP-P200 simulator. 
