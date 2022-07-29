# Jcd.SRecord
This library will load, parse and validate a motorola sRecord 
file according to the [Ubuntu srec manpage](https://manpages.ubuntu.com/manpages/trusty/man5/srec.5.html) 
and the [Wikipedia SREC (file format)](https://en.wikipedia.org/wiki/SREC_(file_format)) article. 


Some inspiration was taken from reading the code by [Vanya A. Sergeev and Jerry G. Scherer](https://github.com/vsergeev/libGISdotnet/blob/master/SRecord.cs)
However, you'll note mine is significantly different.

## Examples
```csharp
    // read all of the data, tracking the parse result for each line.
    var document = SRecordDocument.CreateFromFile("FakeFirmware.s37");
    
    // compute some statistics.
    var parsingStats = document.CalculateParseStatistics();
    var dataStats = document.CalculateDataStatistics();
    
    // Report on what's in the file. 
    Console.WriteLine($"Record type counts:");
    Console.WriteLine($"S0 {dataStats.S0Count}; S1 {dataStats.S1Count}; S2 {dataStats.S2Count}; S3 {dataStats.S3Count}; S4 {dataStats.S4Count}; S5 {dataStats.S5Count}; S6 {dataStats.S6Count}; S7 {dataStats.S7Count}; S8 {dataStats.S8Count}; S9: {dataStats.S9Count}");
    Console.WriteLine();
    Console.WriteLine($"Parsing stats:");
    Console.WriteLine($"Total number of blank lines: {parsingStats.BlankElementCount}");
    Console.WriteLine($"Total number of lines with parsing errors: {parsingStats.ErrorElementCount}");
    Console.WriteLine($"Total number of stand alone comment lines: {parsingStats.StandAloneCommentCount}");
    Console.WriteLine($"Total number of lines with comments: {parsingStats.ElementsWithCommentsCount}");
    Console.WriteLine($"Total number of lines with s-record entries: {parsingStats.ElementsWithSRecordDataCount}");
    Console.WriteLine($"Total number of lines with comments and s-record entries: {parsingStats.SRecordDataWithCommentCount}");
    Console.WriteLine($"Total line count: {parsingStats.TotalElementsCount}");
    /* The above gives the following output:
    Record type counts:
    S0 1; S1 3; S2 0; S3 0; S4 0; S5 1; S6 0; S7 0; S8 0; S9: 1
    
    Parsing stats:
    Total number of blank lines: 0
    Total number of lines with parsing errors: 0
    Total number of stand alone comment lines: 3
    Total number of lines with comments: 3
    Total number of lines with s-record entries: 6
    Total number of lines with comments and s-record entries: 0
    Total line count: 9
    */

    // now access the data and upload the firmware to a device.
    foreach (var record in document.SRecords)
    {
        // get a byte array if it's S1, S2, S3 and send firmware to the device.
        if (record.Type.Key == "S1" || record.Type.Key == "S2" || record.Type.Key == "S3")
            UploadToFirmware(record.Address, record.Type.AddressLengthInBytes, record.Data.ToArray());
        // set the execution address if S7, S8, or S9
        else if (record.Type.Key == "S7" || record.Type.Key == "S8" || record.Type.Key == "S9")
            SetExecutionAddress(record.Address,record.Type.AddressLengthInBytes);
    }
```


[![GitHub](https://img.shields.io/github/license/jason-c-daniels/Jcd.SRecord)](https://github.com/jason-c-daniels/Jcd.SRecord/blob/main/LICENSE)
[![Build status](https://ci.appveyor.com/api/projects/status/jk8jngyew880ouc5?svg=true)](https://ci.appveyor.com/project/jason-c-daniels/jcd-srecord)
[![CodeFactor Grade](https://img.shields.io/codefactor/grade/github/jason-c-daniels/Jcd.SRecord)](https://www.codefactor.io/repository/github/jason-c-daniels/Jcd.SRecord)

[![MyGet](https://img.shields.io/myget/jason-c-daniels/v/Jcd.SRecord?logo=nuget)](https://www.myget.org/feed/jason-c-daniels/package/nuget/Jcd.SRecord)
[![Nuget](https://img.shields.io/nuget/v/Jcd.SRecord?logo=nuget)](https://www.nuget.org/packages/Jcd.SRecord)

[![API Docs](https://img.shields.io/badge/Read-The%20API%20Documentation-blue?style=for-the-badge)](https://github.com/jason-c-daniels/Jcd.SRecord/blob/main/docs/index.md)
