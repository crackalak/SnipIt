[Setup]

#define MyAppName "SnipIt"
#define MyAppPublisher "Rizzen"
#define MyAppExeName "SnipIt.exe"

AppPublisher={#MyAppPublisher}
; this is the name that will appear in the install program as the name
; of the program being installed
appname={#MyAppName}

; this only appears during installation
appvername={#MyAppName}

; this is the name of the directory that the program will be installed
; on on the clients machine. {sd} = system drive on the target machine
; would expect this to be c:
defaultdirname={pf}\{#MyAppName}

setuplogging=yes

SetupIconFile=..\..\images\{#MyAppName}.ico
OutputBaseFilename={#MyAppName}_Setup

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked

; these are the files to be installed and registered during installation
; {app}
[Files]
; Main program files
source: {#MyAppExeName}; destdir: {app}
source: ..\..\images\{#MyAppName}.ico; destdir: {app}

[Icons]
Name: {commonprograms}\Rizzen\{#MyAppName}; Filename: {app}\{#MyAppExeName}; IconFilename: {app}\{#MyAppName}.ico
Name: {commondesktop}\{#MyAppName}; Filename: {app}\{#MyAppExeName}; Tasks: desktopicon; IconFilename: {app}\{#MyAppName}.ico
