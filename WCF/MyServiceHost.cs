using System;
using System.ServiceModel;

public class MyServiceHost
{
    public ServiceHost myServiceHost = null;

    public void StartService(String sIp, String sPort)
    {
        NetTcpBinding binding = new NetTcpBinding();
        binding.MaxReceivedMessageSize = 2147483646;
        Uri baseAddress = new Uri("net.tcp://" + sIp + ":" + sPort + "/RemoteService");
        myServiceHost = new ServiceHost(typeof(WCFServer.RemoteService), baseAddress);
        myServiceHost.AddServiceEndpoint(typeof(WCFServer.IRemoteService), binding, baseAddress);
        myServiceHost.Open();
    }

    public void StopService()
    {
        //Call StopService from your shutdown logic (i.e. dispose method)
        if (myServiceHost.State != CommunicationState.Closed)
            myServiceHost.Close();
    }
}
