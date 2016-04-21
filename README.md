# xamarin-plugin-asreader-demo
Sample project for Xamarin using AsReader

This is created by Xamarin Studio.

# How to use
## Download AsReader DLL
download dll and import project file.  
<https://developer.asreader.jp/sdk/xamarin/AsReader.dll>

## Add AsReader protocol
Add following identifiers to Supported external accessory protocols in plist.

| model | protocol string|
|:------|:---------------|
|ASX-510R, 520R | jp.co.asx.asreader.barcode |  
|ASR-010D, 020D | jp.co.asx.asreader.6dongle.barcode  |
|ASX-300R, 301R | jp.co.asx.asreader.rfid  |
|ASR-030D, 031D | jp.co.asx.asreader.6dongle.rfid |

## Add a file extension is mm
Even though file is empty, please add the file extension is mm.  
ex) dummy.mm

## See SDK Manual
Check the documentation from the following site about how to use API.
It is for the Objective-C, but the method name is almost the same.  
<http://developer.asreader.jp/sdk/second_en.php>

