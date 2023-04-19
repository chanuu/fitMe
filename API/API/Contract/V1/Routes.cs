namespace API.Contract.V1
{
    public static class Routes
    {
        public const string Root = "api";
        public const string Version = "V1";

        public const string Base = $"{Root}/{Version}";
        public static class Users
        {
            public const string GetAll = Base + "/users";
            public const string Create = Base + "/users";
            public const string Get = Base + "/users/{id}";
            public const string GetProfile = Base + "/users/{id}/profile";
        }

        public static class Company
        {
            public const string GetAll = Base + "/companies";
            public const string Get = Base + "/company/{id}";
            public const string Create = Base + "/company";
            public const string Update = Base + "/company";
            public const string Disable = Base + "/company/{id}/disable";
            public const string settings = Base + "/company/{id}/setting";

        }

        public static class Member
        {
            public const string GetAllMembers = Base + "/members";
            public const string Get = Base + "/members/{id}";
            public const string Create = Base + "/member";
            public const string Update = Base + "/member";
            public const string Disable = Base + "/member/{id}/disable";
            public const string ViewProfile = Base + "/member/{id}/profile";
            public const string ViewAttendane = Base + "/member/{id}/attendance";
            public const string ViewWorkot = Base + "/member/{id}/workout";

        }

        public static class TimeSlots
        {
            public const string GetAllTimeSlots = Base + "/company/{id}/timeslots";
            public const string GetAvaibleTimeSlots = Base + "/company/{id}/timeslots/open";
            public const string GetBookedTimeSlots = Base + "/company/{id}/timeslots/book";
            public const string ReserveTimeSlot = Base + "/company/{id}/timeslots/{id}/book";


        }

        public static class Goals
        {
            public const string GetAllGoalsByMember = Base + "/members/{id}/goals";
            public const string CreateGoal = Base + "/members/{id}/goal";
        }

        public static class Payment
        {
            public const string MakePayment = Base + "/members/{id}/payment";
            public const string GetDuePayementByMember = Base + "/members/{id}/Payments/Due";
            public const string GetAllDuePayments = Base + "/company/{id}/Payments";
        }
    }
}
