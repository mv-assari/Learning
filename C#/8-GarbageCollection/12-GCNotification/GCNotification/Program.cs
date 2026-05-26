GC.RegisterForFullGCNotification(99, 99);

Thread startPolling = new Thread(() =>
{
    while (true)
    {
        GCNotificationStatus fgc = GC.WaitForFullGCApproach();
        if (fgc == GCNotificationStatus.Succeeded)
        {
            Console.WriteLine("fullgc will be running soon");
        }
        else if (fgc == GCNotificationStatus.Timeout)
            continue;

        fgc= GC.WaitForFullGCComplete();
        if (fgc == GCNotificationStatus.Succeeded)
        {
            Console.WriteLine("full gc ended");
        }
        else if (fgc == GCNotificationStatus.Timeout)
            continue;
    }
});
startPolling.Start();





List<byte[]> data =new List<byte[]>();
while (true)
{
    data.Add(new byte[1024]);
    if (data.Count > 150000)
    {
        data.Clear();
    }
}