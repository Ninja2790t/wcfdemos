1. Create Service Interfaces Project(Services.Std.Interface)
	- Create class library project
	- Add System.ServiceModel.dll reference
	- Create service interface & define operations and decorate with WCF attributes
	NOTE: This project can be shared between Service Implementaion project and Proxy Project

2. Create Service Implementation Project (Service.Impl)
	- Create class library project
	- Add System.ServiceModel.dll  and service interface project(Services.Std.Interface) .dll reference
	- Create service class which implements service contract

3. Create Service Host Web Project(Service.Host)
	- Create Empty Web Project 
	- Add System.ServiceModel and Service Implementation project(Service.Impl) reference
	- Add Item --> WCF Service and remove code behind files for created .svc file
	- Add the service implementaion class full name to service attribute in .svc file (ex: Service="Service.Impl.ApciService")
	- Add service configuration to web.config and enable MEX endpoint behavior
	- Browse the application and check if you can see the WSDL for the service
	NOTE: IIS should be enabled and WWW service is running

4. Create Service Proxy Project (Service.Proxies)
	- Create a class library project 
	- Add System.ServiceModel.dll and service contract project (Services.Std.Interface) reference
	- Create a proxy class for the service contract

5. Create Service Client Project

