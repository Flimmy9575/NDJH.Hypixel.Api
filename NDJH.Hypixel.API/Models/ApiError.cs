namespace NDJH.Hypixel.API.Models;

public record ApiErrorModel(bool Success, string Cause, bool? Throttle, bool? Global);