# xamarin-plugin-asreader-demo
Sample project for Xamarin using AsReader

This is created by Xamarin Studio.

# How to use
## Download AsReader DLL
Download the dll file and import the project.  
<https://developer.asreader.jp/sdk/xamarin/AsReader.dll>

## Add AsReader protocol
Add following identifiers to Supported external accessory protocols in plist.

| model | protocol string|
|:------|:---------------|
|ASX-510R, 520R | jp.co.asx.asreader.barcode |  
|ASR-010D, 020D | jp.co.asx.asreader.6dongle.barcode  |
|ASX-300R, 301R | jp.co.asx.asreader.rfid  |
|ASR-030D, 031D | jp.co.asx.asreader.6dongle.rfid |

## Required: Add an empty file with an .mm extension
Even though the file is empty, it must exist.
Please add a file with the extension .mm
For example: dummy.mm

## See SDK Manual
Check the documentation from the following site about how to use the API.
It is for Objective-C, but the method is almost the same.  
<http://developer.asreader.jp/sdk/second_en.php>

