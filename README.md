Author: **Farrukh Mirza**  
Date: 01/06/2017  
Location: Dublin, Republic of Ireland  


Introduction
========
A very simple cross-platform .Net Core RESTful App and Web API (REST) tested on Linux (Ubuntu 16.04) and Windows 7. 
This application can work on embedded Kestrel engine on port 80 (HTTP). The configuration can very easily be loaded from a configurations file.
Please note that the project does not have IIS Integration as the target was to host it on Linux as well as on Windows.

WEB UI: http://localhost/   
WEB API URI: http://{host}/api/cities   

The API provides a basic RESTful CRUD (without the update part) with in-memory data and JSON representation as data exchange format of choice.

When published from Visual Studio it creates the deployables inside bin/Release/netcoreapp1.1   
1.	All the files can be simply placed/copied in any folder on the VM where we want to host the app  
2.	Need to change the additionalProbingPaths property in Citiesinfo.API.runtimeconfig.dev.json file as per the environment   
3.	To run simply issue the command on terminal:  <code>$ dotnet Citiesinfo.API.dll</code>   
	a.	On Linux: <code>$ sudo dotnet Citiesinfo.API.dll </code>, where sudo provides root privileges required by Kestrel server.   


This project only reflects the front-end architecture and not the N-tier architecture going all the way to the database.

Tools
========

1. Visual Studio 2017 Community Edition   
2. Asp .Net Core and C# .Net core

Licenses
========
**net-core-sample-app**(this service) is provided under MIT License.

.Net core platform framework is provided under Apache License

Further Help
========

[Getting Linux environment setup with .Net Core] (https://www.microsoft.com/net/core#linuxubuntu) - The version of the OS MUST exactly match the one supported by Microsoft.

