using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public interface IMap
    {
        string LoadMap(string location);
    }

    public interface IIntelligence
    {
        string GatherIntel(string location);
    }

    public interface ILogger
    {
        void Log(string message);
    }

    public interface IMissionPlanner
    {
        void PlanMission(string location);
    }

    public class MapService
    {
        public string LoadMap(string location)
        {
            return $"Loaded terrain map for {location}";
        }
    }
    public class IntelligenceService : IIntelligence
    {
        public string GatherIntel(string location)
        {
            return $"Enemy activity in {location}: HIGH";
        }
    }
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($" [FILE] {message}");
        }
    }
    public class MissionPlanner
    {
        private ILogger logger;
        private IIntelligence intelService;
        private IMap mapService;

        public void PlanMission(string location)
        {
            Console.WriteLine("MISSION BRIEFING");
            var intel = intelService.GatherIntel(location);
            var map = mapService.LoadMap(location);
            Console.WriteLine(intel);
            Console.WriteLine(map);
            logger.Log($"Mission planned for {location}");
        }
    }

    public class ControlRoom
    {
        private IMissionPlanner planner;

        public void Launch()
        {
            planner.PlanMission("Sector 9");
        }
    }

}

