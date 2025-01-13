namespace Application.Common.Interfaces
{
    /// <summary>
    /// Interface para comandos que necesitan trackear el usuario que realiza la acción
    /// </summary>
    public interface IUserTrackable
    {
        string UserId { get; set; }
    }
} 