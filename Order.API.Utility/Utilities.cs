namespace Order.API.Utility
{

    /// <summary>
    /// Utility helper class
    /// </summary>
    public static class HelperConst
    {
        #region ResponseMessage
        public const string SuccessMessage = "Sucess";
        public const string FailedMessage = "Failed";
        public const string NoDataMessage = "No Data Found";
        #endregion

        #region OrderStatus
        public const string Delivered = "Delivered";
        public const string Failed = "Failed";
        public const string Dispatch = "Dispatch";
        #endregion

    }
}