taskkill /IM WebVue.exe /F
echo d | xcopy /s/e/y "%~dp0" C:\BigBag\Program
schtasks /run /tn "BigBag Data"
PAUSE