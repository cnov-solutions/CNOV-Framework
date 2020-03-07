@echo off

if not "%1"=="am_admin" (powershell start -verb runas '%0' am_admin & exit /b)

sc query SensrSvc > nul
echo exists
sc config SensrSvc start= disabled


sc query WinHttpAutoProxySvc > nul
echo exists
sc config WinHttpAutoProxySvc start= disabled

sc query WinRM > nul
echo exists
sc config WinRM start= disabled

sc query WerSvc > nul
echo exists
sc config WerSvc start= disabled

sc query WcsPlugInService > nul
echo exists
sc config WcsPlugInService start= disabled

sc query ALG > nul
echo exists
sc config ALG start= disabled

sc query BDESVC > nul
echo exists
sc config BDESVC start= disabled

sc query EFS > nul
echo exists
sc config EFS start= disabled

sc query Fax > nul
echo exists
sc config Fax start= disabled

sc query hidserv > nul
echo exists
sc config hidserv start= disabled

sc query SessionEnv > nul
echo exists
sc config SessionEnv start= disabled

sc query TermService > nul
echo exists
sc config TermService start= disabled

sc query UmRdpService > nul
echo exists
sc config UmRdpService start= disabled

sc query TabletInputService > nul
echo exists
sc config TabletInputService start= disabled

sc query WbioSrvc > nul
echo exists
sc config WbioSrvc start= disabled


sc delete DiagTrack
sc delete dmwappushservice
echo «» > C:\\ProgramData\\Microsoft\\Diagnosis\\ETLLogs\\AutoLogger\\AutoLogger-Diagtrack-Listener.etl
reg add «HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection» /v AllowTelemetry /t REG_DWORD /d 0 /f
