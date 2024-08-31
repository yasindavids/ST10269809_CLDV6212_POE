using Azure;
using Azure.Data.Tables;

namespace ST10269809_CLDV6212_POE.Models
{
    public class CustomerProfile : ITableEntity
    {
        
            public string PartitionKey { get; set; }
            public string RowKey { get; set; }
            public DateTimeOffset? Timestamp { get; set; }
            public ETag ETag { get; set; }

            // Custom properties
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }


        }
    }
