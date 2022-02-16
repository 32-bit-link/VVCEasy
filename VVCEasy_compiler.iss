; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "VVCEasy"
#define MyAppVersion "0.0.1"
#define MyAppPublisher "Martin Eesmaa"
#define MyAppURL "https://github.com/MartinEesmaa/VVCEasy"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{CEFE5C0E-F29A-4459-A5FC-53267C743303}}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppName}
LicenseFile=C:\Users\User\Downloads\VVCEasy\LICENSE
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
OutputDir=C:\Users\User\Downloads
OutputBaseFilename=VVCEasy
Compression=lzma2/ultra64
SolidCompression=yes
WizardStyle=modern
InternalCompressLevel=ultra64
DiskSpanning=True
CompressionThreads=1

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Files]
Source: "C:\Users\User\Downloads\VVCEasy\*"; DestDir: "{win}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

