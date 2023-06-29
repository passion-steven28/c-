using System.ComponentModel.DataAnnotations;

namespace ticketer.core.entities;

public class Ticket
{
    [Key]
    public long Id
    {
        get; set;
    }

    public DateTime Time
    {
        get; set;
    }

    public required string PassengerName
    {
        get;
        set;
    }

    public long PassengerSSN
    {
        get;
        set;
    }

    public string From
    {
        get;
        set;
    }

    public string To
    {
        get;
        set;
    }

    public int Price
    {
        get;
        set;
    }

    public DateTime CreatedAt
    {
        get;
        set;
    } = DateTime.Now;

    public DateTime UpdatedAt
    {
        get;
        set;
    } = DateTime.Now;

    public string ConfidentialComment
    {
        get;
        set;
    } = "Normal";
}
