@echo off

if not "%1"=="am_admin" (powershell start -verb runas '%0' am_admin & exit /b)

del "%tmp%" /s /q 
del "%temp%" /s /q 
del C:\*.tmp /s /q