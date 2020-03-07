@echo off

if not "%1"=="am_admin" (powershell start -verb runas '%0' am_admin & exit /b)

sc config WSearch start= disabled
sc config WMPNetworkSvc start= disabled
sc config SNMPTRAP start= disabled
sc config SCPolicySvc start= disabled
sc config SCardSvr start= disabled
sc config RemoteRegistry start= disabled
sc config RpcLocator start= disabled
sc config WPCSvc start= disabled
sc config CscService start= disabled
sc config napagent start= disabled
sc config Netlogon start= disabled
sc config MSiSCSI start= disabled
sc config iphlpsvc start= disabled
sc config TrkWks start= disabled
sc config CertPropSvc start= disabled
sc config PeerDistSvc start= disabled
sc config bthserv start= disabled
