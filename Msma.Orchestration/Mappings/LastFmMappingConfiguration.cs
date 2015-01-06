using AutoMapper;

namespace Msma.Orchestration.Mappings
{
    public class LastFmMappingConfiguration
    {
        public void SetupMappings()
        {
            Mapper.CreateMap<Msma.Integrations.LastFm.Models.Artist, Domain.Models.Artist>();
            Mapper.CreateMap<Msma.Integrations.LastFm.Models.Album, Domain.Models.Album>();
            Mapper.CreateMap<Msma.Integrations.LastFm.Models.AlbumInTopAlbums, Domain.Models.Album>();
            Mapper.CreateMap<Msma.Integrations.LastFm.Models.AlbumInTrack, Domain.Models.Album>();
            Mapper.CreateMap<Msma.Integrations.LastFm.Models.Track, Domain.Models.Track>();
            Mapper.CreateMap<Msma.Integrations.LastFm.Models.TrackInTracklist, Domain.Models.Track>();
            Mapper.CreateMap<Msma.Integrations.LastFm.Models.Tracklist, Domain.Models.Tracklist>();
            Mapper.CreateMap<Msma.Integrations.LastFm.Models.ArtistBio, Domain.Models.ArtistBio>();
            Mapper.CreateMap<Msma.Integrations.LastFm.Models.AlbumInfo, Domain.Models.AlbumInfo>();
        }
    }
}