MIT License (Open source)


A very simple cross-platform .Net Core RESTful App and Web API (REST) tested on Linux (Ubuntu 16.04) and Windows 7. 
This application can work on embedded Kestrel engine on port 80 (HTTP). The configuration can very easily be loaded from a configurations file.
Please note that the project does not have IIS Integration as the target was to host it on Linux as well as on Windows.

WEB API URI: http://{host}/api/cities

The API provides a basic RESTful CRUD (without the update part) with in-memory data and JSON representation as data exchange format of choice.

Getting Linux environment setup: https://www.microsoft.com/net/core#linuxubuntu

When published from Visual Studio it creates the deployables inside bin/Release/netcoreapp1.1
	a.	All the files can be simply placed/copied in any folder on the VM where we want to host the app
	b.	Need to change the additionalProbingPaths property in Citiesinfo.API.runtimeconfig.dev.json file as per the environment
	c.	To run simply issue the command on terminal:  <code>$ dotnet Citiesinfo.API.dll</code>
		i.	On Linux: <code>$ sudo dotnet Citiesinfo.API.dll </code>, where sudo provides root privileges required by Kestrel server.


