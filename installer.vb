Imports System.IO
Imports System.IO.Compression

Sub Main()

#Region "Dependencies"

' P2Pool
Dim P2Pool_Location as String = "C:\P2Pool"
My.Computer.Network.DownloadFile("https://github.com/Rav3nPL/p2pool-rav/archive/master.zip",P2Pool_Location)
ZipFile.ExtractToDirectory(P2Pool_Location & "master.zip", P2Pool_Location)

' Python
Dim Python_Location as String = "C:\Python"
My.Computer.Network.DownloadFile("https://www.python.org/ftp/python/2.7.6/python-2.7.6.msi",Python_Location)
Process.Start(Python_Location & "python-2.7.6.msi")

' Twisted
Dim Twisted_Location as String = "C:\Twisted"
My.Computer.Network.DownloadFile("http://twistedmatrix.com/Releases/Twisted/13.2/Twisted-13.2.0.win32-py2.7.msi", Twisted_Location)
Process.Start(Twisted_Location & "Twisted-13.2.0.win32-py2.7.msi")

' Zope Interface
Dim Zope_Location as String = "C:\Zope"
My.Computer.Network.DownloadFile("https://pypi.python.org/packages/2.7/z/zope.interface/zope.interface-3.8.0.win32-py2.7.exe", Zope_Location)
Process.Start(Zope_Location & "zope.interface-3.8.0.win32-py2.7.exe")

' WMI
Dim WMI_Location as String = "C:\WMI"
My.Computer.Network.DownloadFile("https://pypi.python.org/packages/source/W/WMI/WMI-1.4.9.zip", WMI_Location)
ZipFile.ExtractToDirectory(WMI_Location & "WMI-1.4.9.zip)
Process.Start(WMI_Location & "WMI-1.4.9.zip)

' GCC
Dim GCC_Location as String = "C:\GCC"
My.Computer.DownloadFile("https://github.com/develersrl/gccwinbinaries/releases/download/v1.1/gcc-mingw-4.3.3-setup.exe", GCC_Location)
Process.Start(GCC_Location & "gcc-mingw-4.3.3-setup.exe")
MessageBox.show("Please Select the Radio Button asking to link with MSVCR90.DLL")

#End Region
#Region "Setup"
Process.Start(P2Pool_Location & "\litecoin_scrypt\setup.py build --compile=mingw install")
In
Run the following: setup.py build --compile=mingw32 install
Go to %appdata%/dogecoin/ (for win7)
Create a .conf file (create a text file and rename - make sure unknown file extensions are shown - http://support.microsoft.com/kb/865219) called 'dogecoin.conf'
Edit dogecoin.conf to include:

