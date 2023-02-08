# OneDriveSuspender
OneDriveSuspender creates .bat files to launch applications while suspending OneDrive until those applications are closed.

# Requirements
OneDriveSuspender currently requires [pssuspend](https://learn.microsoft.com/en-gb/sysinternals/downloads/pssuspend) to be added to PATH. 
> I intend for this to be done behind the scenes in later versions.

# Usage
* Select the application that you want to suspend OneDrive while running
* Click 'Create .bat' to create a .bat file in the current directory
* Use this .bat to launch your application, and it will suspend the OneDrive process upon launch and re-enable it on quit

### Warning
If OneDrive is told by multiple .bat scripts to suspend, it requires as many commands to resume.
Try to avoid running multiple instances of OneDriveSuspender .bat files, but if OneDrive gets stuck in suspension repeat ``` pssuspend -r onedrive ``` in cmd until it resumes. 

Not the most elegant, unfortunately.
