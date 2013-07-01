; replace awh with progroot throughout script
[Setup]

#define MyAppName "SnipIt"
#define MyAppPublisher "Rizzen"
#define MyAppExeName "SnipIt.exe"

; this is the name that will appear in the install program as the name
; of the program being installed
appname=SnipIt

; this only appears during installation
appvername=SnipIt

; this is the name of the directory that the program will be installed
; on on the clients machine. {sd} = system drive on the target machine
; would expect this to be c:
defaultdirname={pf}\SnipIt

; inhibits the display of the directory the program is to be istalled in
; during installation
disabledirpage=yes

setuplogging=yes

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked

; these are the files to be installed and registered during installation
; {app}
[Files]
; Main program files
source: SnipIt.exe; destdir: {app}
source: ..\..\images\snipit.ico; destdir: {app}

[Icons]
Name: {commonprograms}\Rizzen\{#MyAppName}; Filename: {app}\{#MyAppExeName}; IconFilename: {app}\snipit.ico
Name: {commondesktop}\{#MyAppName}; Filename: {app}\{#MyAppExeName}; Tasks: desktopicon; IconFilename: {app}\snipit.ico
