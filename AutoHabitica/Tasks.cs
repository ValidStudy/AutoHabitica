namespace AutoHabitica
{
    public class ApiObject
    {
        public bool success { get; set; }
        public Task[] data { get; set; }
    }

    public class Task
    {
        public string type { get; set; }
        public string notes { get; set; }
        public string attribute { get; set; }
        public string text { get; set; }
        public string id { get; set; }
        public bool completed { get; set; }
        public TimeSpan RunningTime { get; set; }
        public TimeSpan TargetTime { get; set; }
        public string? TitleName { get; set;}
        public bool Enabled {  get; set; }
        public override string ToString()
        {
            return text+" Running for "+Math.Round(RunningTime.TotalMinutes,2)+
                "min. Target "+TargetTime.TotalMinutes+
                "min."+" Related process "+TitleName;
        }
    }
}

