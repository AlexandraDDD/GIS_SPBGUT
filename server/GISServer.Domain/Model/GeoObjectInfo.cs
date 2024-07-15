namespace GISServer.Domain.Model
{
    public class GeoObjectInfo
    {
        public Guid Id { get; set; }
        public String? FullName { get; set; }
        public String? ShortName { get; set; }
        public String? AuthoritativeKnowledgeSource { get; set; }
        public int? Version { get; set; }
        public String? LanguageCode { get; set; }
        public String? Language { get; set; }
        public Status? Status { get; set; }
        public DateTime? ArchiveTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? CreationTime { get; set; }
        public String? CommonInfo { get; set; }
        public Guid? GeographicalObjectId { get; set; }
        public GeoObject? GeographicalObject { get; set; }
        public List<GeoClassifier>? GeoClassifiers { get; set; } = new List<GeoClassifier>();
        public List<GeoObjectsGeoClassifiers> GeoObjectsGeoClassifiers { get; set; } = new List<GeoObjectsGeoClassifiers>();
    }
}