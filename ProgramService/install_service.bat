sc delete "BetonarkaModbusProfinet" 
sc create "BetonarkaModbusProfinet" binPath="%~dp0BetonarkaKocovceService.exe" start=auto
sc start BetonarkaModbusProfinet
PAUSE