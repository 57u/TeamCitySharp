﻿namespace TeamCitySharpAPI.DomainEntities
{
    public class Credentials : ITeamCityCredentials
    {
        public string HostName { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public bool UseSSL { get; set; }
    }
}