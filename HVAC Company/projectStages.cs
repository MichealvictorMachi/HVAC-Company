using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HVAC_Company
{
    /// <summary>
    /// ABSTRACT CLASS
    /// </summary>
    public abstract class ProjectStage
    {
        public abstract double ConfirmCompletion();

    }
    
    /// 
    /// MAIN CLASS THAT CALCULATES THE PROJECT COMPLETION PERCENTAGE
    /// 
    internal class ProjectCompletionRate
    {
        ///
        /// Main Method that calculates the various stages percentage completion rate.
        ///
        double TotalCustomerBalance(List<ProjectStage> project)
        {
            double rate = 0;
            try
            {
                foreach (var stages in project)
                {
                    rate += stages.ConfirmCompletion();
                }
            }
            catch (Exception ex)
            {
                var error = ex.Message;
                return 0;
            }
            return rate;
        }
    }
    /// 
    /// DURING THE INITIATION STAGE THE PROJECT MANAGER ENSURES REGULAR COMMUNICATION WITH THE CLIENT AND ALSO QUOTES AND BID FOR THE PROJECT
    /// 
    /// this class inherits projectStage

    class Initiation : ProjectStage
    {
        // 
        public string? Quoting { get; set; }
        public string? BiddingCompleted { get; set; }
        public string? Documentations { get; set; }

        void CommunicatesWithClients()
        {
            var communicates =new Communications();
            communicates.sendMails();
            communicates.ScheduleMeeting();
        }
        public override double ConfirmCompletion()
        {
            return 0;
        }
    }
    /// <summary>
    /// THE PLANNING STAGE, THE ENGINEERS VISITS THE SITE TO ACCESS THE SPACE AND ALSO DO SOME DESIGN ON HOW CARRY OUT THE PROJECT
    /// </summary>
    class Planning : ProjectStage
    {
         /// 
        /// properties of the planning stage
        ///  
        public string? problemDefinition { get; set; }
        public string? StakeholdersIdentification { get; set; }
        public string? Design { get; set; }
        public string? MarketSurvey { get; set; }

        /// <summary>
        /// Budgetting method implementing Budgetting class
        /// </summary>
        void Budgetting()
        {
            var budget = new Budgetting();
            budget.budgetDev();
            
        }
        /// <summary>
        /// Sites visitation implementing Communication class.
        /// </summary>
        void SiteVisitation()
        {
            Communications siteVisit = new Communications();
            siteVisit.sendMails();
            siteVisit.ScheduleMeeting();

        }
        public override double ConfirmCompletion()
        {
            return 0;
        }

    }
    /// <summary>
    /// THE EXECUTION STAGE WHERE THE PROJECT INSTALLATION BEGINS AND EXECUTION OF THE DESIGN BY FOLLOWING AN OUTLINED GANTTCHART
    /// </summary>
    class Execution : ProjectStage
    {
        /// <summary>
        /// properties of the execution stage
        /// </summary>
        public string? TeamAss { get; set; }
        public string? DraftGanttChart { get; set; } 
        public string? LogisticsMove { get; set; }
        void KickoffMeeting()
        {
            Communications kickoff = new Communications();
            kickoff.sendMails();
            kickoff.ScheduleMeeting();
        }
        void BudgetImp()
        {
            Budgetting Implement = new Budgetting();
            Implement.budgetimplementation();   
        }
        public override double ConfirmCompletion()
        {
            return 0;
        }

    }
    /// <summary>
    /// THE MONITORING AND CONTROL STAGE IS WHERE THE PROJECT IS BEING COMPLETED AND HANDEDOVER TO THE CLIENTS
    /// </summary>
    class MonitoringAndControl : ProjectStage   
    {
        /// <summary>
        /// properties of the monitoring and control stage
        /// </summary>
        public string ReportProgress { get; set; } = string.Empty;
        public double EvaluationRate { get; set; }
        public string HandleRisingProblem { get; set; } = string.Empty;
        void ScrumMeeting()
        {
           Communications scrum = new Communications();
            scrum.sendMails();
            scrum.ScheduleMeeting();
        }
        public override double ConfirmCompletion()
        {
            return EvaluationRate;
        }

    }
    /// <summary>
    /// THE COMMUNICATIONS CLASS THAT HANDLES SENDING NOTIFICATIONS TO BOTH CLIENTS AND STAFFS
    /// </summary>
    public class Communications
    {
        public string sendMails()
        {
            return "mail sent";
        }
        public string ScheduleMeeting()
        {
            return "Meeting scheduled";
        }
    }
    /// <summary>
    /// THE BUDGETTING CLASS THAT HANDLES BUDGETTING RELATED ISSUES LIKE CREATING ONE AND ENSURING THE BUDGET IS BEING ADHERED TO.
    /// </summary>
    public class Budgetting
    {
        public int budgetDev()
        {
            return 0;
        }
        public int budgetimplementation()
        {
            return 0;
        }
    }
}
