
using Internal.SDK.AISession.DTOs.Enums;

namespace Internal.SDK.AISession.DTOs
{
    public class ModelTypeDTO
    {
        public ModelType? ModelType { get; }

        public string? ModelCode { get; }

        public int? ModelTypeId { get; }

        public ModelTypeDTO(ModelType modelType)
        {
            ModelType = modelType;
        }

        public ModelTypeDTO(string modelCode)
        {
            ModelCode = modelCode;
        }

        public ModelTypeDTO(int modelTypeId)
        {
            ModelTypeId = modelTypeId;
        }

        public static implicit operator ModelTypeDTO(ModelType modelType)
         => new ModelTypeDTO(modelType);

        public static implicit operator ModelTypeDTO(string modelCode)
            => new ModelTypeDTO(modelCode);

        public static implicit operator ModelTypeDTO(int modelTypeId)
            => new ModelTypeDTO(modelTypeId);
    }
}
