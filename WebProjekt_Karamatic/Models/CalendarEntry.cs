namespace WebProjekt_Karamatic.Models {
    public class CalendarEntry {
        // Eigenschaften
        public int EntryId { get; set; } // Eindeutige ID des Eintrags
        public string Title { get; set; } // Titel des Eintrags
        public DateTime StartTime { get; set; } // Startzeit des Eintrags
        public DateTime EndTime { get; set; } // Endzeit des Eintrags
        public string Description { get; set; } // Beschreibung des Eintrags
        public int UserId { get; set; } // ID des Benutzers, dem der Eintrag gehört

        // Konstruktor
        public CalendarEntry(int entryId, string title, DateTime startTime, DateTime endTime, string description, int userId) {
            EntryId = entryId;
            Title = title;
            StartTime = startTime;
            EndTime = endTime;
            Description = description;
            UserId = userId;
        }
    }
}
