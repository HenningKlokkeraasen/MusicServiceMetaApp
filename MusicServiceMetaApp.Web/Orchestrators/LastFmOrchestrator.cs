using System.Collections.Generic;
using System.Configuration;
using AutoMapper;
using Msma.Domain.Dtos;
using Msma.Domain.Enums;
using Msma.Domain.Models;
using Msma.Integrations.LastFm;

namespace MusicServiceMetaApp.Web.Orchestrators
{
    internal class LastFmOrchestrator : OrchestratroBase
    {
        private readonly LastFmGateway _gateway = new LastFmGateway(ConfigurationManager.AppSettings["LastFmDeveloperKey"]);
        private const SourceEnum Source = SourceEnum.LastFm;

        internal ArtistDto GetArtist(string id)
        {
            var artist = Mapper.Map<Artist>(_gateway.FetchArtist(id));
            var albums = new List<Album>();//TODO
            var singles = new List<Album>();//TODO
            var appearsOn = new List<Album>();//TODO

            ArtistDto dto = new ArtistDto
            {
                Artist = artist,
                Albums = albums,
                Singles = singles,
                AppearsOn = appearsOn
            };

            return SetSoruce(dto, Source);
        }

    }
}