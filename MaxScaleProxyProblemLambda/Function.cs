using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaxScaleProxyProblem;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace MaxScaleProxyProblemLambda
{
    public class Function
    {
        
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void FunctionHandler(string input, ILambdaContext context)
        {
            var dbContext = new MaxScaleProxyDbContext();
            int intTest = 1337;
            long longTest = 1337;
            DateTime dateTimeTest = DateTime.Now;
            string stringTest = "test";

            var report = new ClickPerformanceReportModel
            {
                AccountDescriptiveName = stringTest,
                AdFormat = stringTest,
                AdGroupId = 123123123,
                AdGroupName = stringTest,
                AdGroupStatus = stringTest,
                AdNetworkType1 = stringTest,
                AdNetworkType2 = stringTest,
                AdVariationControlTrialArmId = longTest,
                AdVariationTreatmentTrialArmId = longTest,
                AdVariationTrialId = longTest,
                AoiCityCriteriaId = stringTest,
                AoiCountryCriteriaId = stringTest,
                AoiMetroCriteriaId = stringTest,
                AoiMostSpecificTargetId = stringTest,
                AoiRegionCriteriaId = stringTest,
                CampaignId = longTest,
                CampaignLocationTargetId = longTest,
                CampaignName = stringTest,
                CampaignStatus = stringTest,
                Clicks = intTest,
                ClickType = stringTest,
                CreativeId = longTest,
                CriteriaId = longTest,
                CriteriaParameters = stringTest,
                Date = dateTimeTest,
                Device = stringTest,
                ExternalCustomerId = longTest,
                GclId = stringTest,
                Id = intTest,
                KeywordMatchType = stringTest,
                LopCityCriteriaId = longTest,
                LopCountryCriteriaId = longTest,
                LopMetroCriteriaId = longTest,
                LopMostSpecificTargetId = longTest,
                LopRegionCriteriaId = longTest,
                MonthOfYear = stringTest,
                Page = intTest,
                Slot = stringTest,
                Timestamp = dateTimeTest,
                UserListId = longTest
            };
            try
            {
                dbContext.ClickPerformanceReports.Add(report);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Logger.LogLine("Test failed with an exception");
                context.Logger.LogLine(ex.ToString());
            }
        }
    }
}
