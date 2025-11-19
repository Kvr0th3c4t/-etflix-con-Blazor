using Ñetflix.Models;
using Refit;

namespace Ñetflix.Interfaces
{
    public interface ISerie
    {
        [Get("/series")]
        Task<IEnumerable<SerieResponseDto>> GetAllSeriesAsync();

        [Get("/series/{_id}")]
        Task<SerieResponseDto> GetSerieByIdAsync(string _id);

        [Post("/series")]
        Task<SerieCreatedResponse> CreateSerieAsync([Body] SerieCreateDto serie);

        [Put("/series/{_id}")]
        Task<SerieUpdateResponse> UpdateSerieAsync(string _id, [Body] SerieUpdateDto serie);

        [Delete("/series/{_id}")]
        Task<SerieDeletedResponse> DeleteSerieAsync(string _id);
    }
}
