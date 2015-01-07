using System.Collections.Generic;
using AutoMapper;
using Msma.Domain.Dtos;
using Msma.Domain.Enums;
using Msma.Domain.Models;
using Msma.Integrations.MusicBrainz;

namespace Msma.Orchestration.Integrations
{
    public class MusicBrainsOrchestrator : OrchestratorBase
    {
        private readonly MusicBrainzGateway _gateway = new MusicBrainzGateway();
        private const SourceEnum Source = SourceEnum.MusicBrainz;

        public ArtistDto GetArtist(string mbid)
        {
            var unmappedArtist = _gateway.FetchArtist(mbid);
            var artist = Mapper.Map<Artist>(unmappedArtist);
            var bio = new ArtistBio
            {
                YearFormed = unmappedArtist.LifeSpan.Begin,
                PlaceFormed = unmappedArtist.BeginArea.Name
            };

            var dto = new ArtistDto
            {
                Artist = artist,
                Bio = bio
            };

            return SetSoruce(dto, Source);
        }
    }
}
