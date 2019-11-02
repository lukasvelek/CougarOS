namespace cos_api_system
{
    public class Thread
    {

        public void sleep(int time /* time in seconds */)
        {
            System.Threading.Thread.Sleep(time * 1000);
        }

    }
}
