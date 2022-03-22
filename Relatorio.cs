using System;

namespace RelatorioConsolidadoClosedXML
{
    public class Relatorio
    {
        public Relatorio(
            string client,
            string project,
            string role,
            string roleSeniority,
            double workHours,
            double totalValue
        ) 
        {
            Client = client;
            Project = project;
            Role = role;
            RoleSeniority = roleSeniority;
            WorkHours = workHours;
            TotalValue = totalValue;
        }

        public string Client { get; set; }
        public string Project { get; set; }
        public string Role { get; set; }
        public string RoleSeniority { get; set; }
        public double WorkHours { get; set; }
        public double TotalValue { get; set; }
    }
}