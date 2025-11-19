using Ñetflix.Interfaces;
using Ñetflix.Models;

namespace Ñetflix.Services
{
    public class SeriesService : ISeriesService
    {

        private readonly ISerie _api;

        public SeriesService(ISerie api)
        {
            _api = api;
        }

        public Task<SerieCreatedResponse> CreateSerieAsync(SerieCreateDto serieCreateDto)
        {
            return _api.CreateSerieAsync(serieCreateDto);
        }

        public Task<SerieDeletedResponse> DeleteSerieAsync(string _id)
        {
            return _api.DeleteSerieAsync(_id);
        }

        public Task<IEnumerable<SerieResponseDto>> GetAllSeriesAsync()
        {
            return _api.GetAllSeriesAsync();
        }

        public Task<SerieResponseDto> GetSerieByIdAsync(string _id)
        {
            return _api.GetSerieByIdAsync(_id);
        }

        public Task<SerieUpdateResponse> UpdateSerieAsync(string _id, SerieUpdateDto serieUpdateDto)
        {
            return _api.UpdateSerieAsync(_id, serieUpdateDto);
        }
    }
}
