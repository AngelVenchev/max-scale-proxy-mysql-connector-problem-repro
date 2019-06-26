using System;

namespace MaxScaleProxyProblem
{
    public class ClickPerformanceReportModel
    {
        public int Id { get; set; }
        public string AccountDescriptiveName { get; set; }
        public string AdFormat { get; set; }
        public long AdGroupId { get; set; }
        public string AdGroupName { get; set; }
        public string AdGroupStatus { get; set; }
        public string AdNetworkType1 { get; set; }
        public string AdNetworkType2 { get; set; }
        public long AdVariationControlTrialArmId { get; set; }
        public long AdVariationTreatmentTrialArmId { get; set; }
        public long AdVariationTrialId { get; set; }
        public string AoiCityCriteriaId { get; set; }
        public string AoiCountryCriteriaId { get; set; }
        public string AoiMetroCriteriaId { get; set; }
        public string AoiMostSpecificTargetId { get; set; }
        public string AoiRegionCriteriaId { get; set; }
        public long CampaignId { get; set; }
        public long CampaignLocationTargetId { get; set; }
        public string CampaignName { get; set; }
        public string CampaignStatus { get; set; }
        public int Clicks { get; set; }
        public string ClickType { get; set; }
        public long CreativeId { get; set; }
        public long CriteriaId { get; set; }
        public string CriteriaParameters { get; set; }
        public DateTime Date { get; set; }
        public string Device { get; set; }
        public long ExternalCustomerId { get; set; }
        public string GclId { get; set; }
        public string KeywordMatchType { get; set; }
        public long LopCityCriteriaId { get; set; }
        public long LopCountryCriteriaId { get; set; }
        public long LopMetroCriteriaId { get; set; }
        public long LopMostSpecificTargetId { get; set; }
        public long LopRegionCriteriaId { get; set; }
        public string MonthOfYear { get; set; }
        public int Page { get; set; }
        public string Slot { get; set; }
        public long UserListId { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
