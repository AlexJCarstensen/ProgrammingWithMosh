
using System;
using System.Collections.Generic;

namespace CleanCode.LongParameterList
{
    public class DateRange
    {
        private DateTime _dateFrom;
        private DateTime _dateTo;

        public DateRange(DateTime dateFrom, DateTime dateTo)
        {
            _dateFrom = dateFrom;
            _dateTo = dateTo;
        }

        public DateTime DateFrom
        {
            get { return _dateFrom; }
        }

        public DateTime DateTo
        {
            get { return _dateTo; }
        }
    }

    public class ReservationsQuery
    {
        private DateRange _dateRange;
        private User _user;
        private int _locationId;
        private LocationType _locationType;
        private int? _customerId;

        public ReservationsQuery(DateRange dateRange, User user, int locationId, LocationType locationType, int? customerId = null)
        {
            _dateRange = dateRange;
            _user = user;
            _locationId = locationId;
            _locationType = locationType;
            _customerId = customerId;
        }

        public DateRange DateRange
        {
            get { return _dateRange; }
        }

        public User User
        {
            get { return _user; }
        }

        public int LocationId
        {
            get { return _locationId; }
        }

        public LocationType LocationType
        {
            get { return _locationType; }
        }

        public int? CustomerId
        {
            get { return _customerId; }
        }
    }

    public class LongParameterList
    {
        public IEnumerable<Reservation> GetReservations(ReservationsQuery query)
        {
            if (query.DateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (query.DateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }



        public IEnumerable<Reservation> GetUpcomingReservations(ReservationsQuery query)
        {
            if (query.DateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (query.DateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }


        private static Tuple<DateTime, DateTime> GetReservationDateRange(DateRange dateRange, ReservationDefinition sd)
        {
            if (dateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (dateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }


        public void CreateReservation(DateRange dateRange, int locationId)
        {
            if (dateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (dateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }
    }

    internal class ReservationDefinition
    {
    }

    public class LocationType
    {
    }

    public class User
    {
        public object Id { get; set; }
    }

    public class Reservation
    {
    }
}
