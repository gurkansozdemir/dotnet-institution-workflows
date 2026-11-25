public sealed record AttendanceEntry(string LearnerCode, DateOnly Date, bool Present);

public static class AttendanceRules
{
    public static bool CanRecord(AttendanceEntry entry) =>
        !string.IsNullOrWhiteSpace(entry.LearnerCode) && entry.Date <= DateOnly.FromDateTime(DateTime.UtcNow);
}
