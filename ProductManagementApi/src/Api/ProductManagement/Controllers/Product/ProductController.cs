using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Common.Models;
using Application.Request.Queries.Product;
using Application.Request.Commands.Product;
using Infrastructure.RoleAuthorization;
using Application.Common.Models.Pagination;

namespace ProductManagement.Controllers.Product
{
    /// <summary>
    /// Controlador para la gestión de productos en el sistema
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : SecureBaseApiController
    {
        public ProductController(IMediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// Obtiene la lista paginada de productos registrados en el sistema
        /// </summary>
        /// <param name="query">Parámetros de paginación</param>
        /// <returns>Lista paginada de productos</returns>
        /// <remarks>
        /// Este endpoint retorna una lista paginada de productos disponibles en el sistema.
        /// </remarks>
        [HttpGet]
        [TouchAuthorization("Admin", "User")]
        [ProducesResponseType(typeof(ApiResponse<PaginatedResponse<Domain.Entities.Product>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<PaginatedResponse<Domain.Entities.Product>>>> GetAll([FromQuery] GetProductsQuery query)
        {
            try
            {
                var products = await _mediator.Send(query);

                if (products == null || products.Items.ToList().Count == 0)
                    return ApiError<PaginatedResponse<Domain.Entities.Product>>("No se encontraron productos", StatusCodes.Status404NotFound);

                return ApiResponse(products, "Productos obtenidos exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<PaginatedResponse<Domain.Entities.Product>>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Obtiene un producto específico por su ID
        /// </summary>
        /// <param name="id">ID del producto a buscar</param>
        /// <returns>Producto encontrado</returns>
        /// <remarks>
        /// Este endpoint retorna un producto específico basado en el ID proporcionado.
        /// </remarks>
        [HttpGet("{id}")]
        [TouchAuthorization("Admin", "User")]
        [ProducesResponseType(typeof(ApiResponse<Domain.Entities.Product>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<Domain.Entities.Product>>> GetById(int id)
        {
            try
            {
                var query = new GetProductByIdQuery(id);
                var product = await _mediator.Send(query);

                if (product == null)
                    return ApiError<Domain.Entities.Product>("No se encontró el producto", StatusCodes.Status404NotFound);

                return ApiResponse(product, "Producto obtenido exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<Domain.Entities.Product>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Crea un nuevo producto en el sistema
        /// </summary>
        /// <param name="command">Datos del producto a crear</param>
        /// <returns>Producto creado</returns>
        /// <remarks>
        /// Este endpoint permite crear un nuevo producto con los datos proporcionados.
        /// </remarks>
        [HttpPost]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<Domain.Entities.Product>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<Domain.Entities.Product>>> Create([FromBody] CreateProductCommand command)
        {
            try
            {
                if (!ModelState.IsValid)
                    return ApiError<Domain.Entities.Product>("Datos de producto inválidos", StatusCodes.Status400BadRequest);

                SetCurrentUser(command);
                var product = await _mediator.Send(command);
                return ApiResponse(product, "Producto creado exitosamente", StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return ApiError<Domain.Entities.Product>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Actualiza un producto existente
        /// </summary>
        /// <param name="id">ID del producto a actualizar</param>
        /// <param name="command">Datos actualizados del producto</param>
        /// <returns>Producto actualizado</returns>
        /// <remarks>
        /// Este endpoint permite actualizar un producto existente con los datos proporcionados.
        /// </remarks>
        [HttpPut("{id}")]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<Domain.Entities.Product>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<Domain.Entities.Product>>> Update(int id, [FromBody] UpdateProductCommand command)
        {
            try
            {
                if (!ModelState.IsValid)
                    return ApiError<Domain.Entities.Product>("Datos de producto inválidos", StatusCodes.Status400BadRequest);

                command.ProductId = id;
                SetCurrentUser(command);
                
                var product = await _mediator.Send(command);

                if (product == null)
                    return ApiError<Domain.Entities.Product>("No se encontró el producto", StatusCodes.Status404NotFound);

                return ApiResponse(product, "Producto actualizado exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<Domain.Entities.Product>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Elimina lógicamente un producto del sistema
        /// </summary>
        /// <param name="id">ID del producto a eliminar</param>
        /// <returns>Producto eliminado</returns>
        /// <remarks>
        /// Este endpoint realiza un eliminado lógico del producto especificado.
        /// El usuario que realiza la eliminación se obtiene automáticamente del token JWT.
        /// </remarks>
        [HttpDelete("{id}")]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<Domain.Entities.Product>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<Domain.Entities.Product>>> Delete(int id)
        {
            try
            {
                var command = new DeleteProductCommand { ProductId = id };
                SetCurrentUser(command);
                
                var product = await _mediator.Send(command);

                if (product == null)
                    return ApiError<Domain.Entities.Product>("No se encontró el producto", StatusCodes.Status404NotFound);

                return ApiResponse(product, "Producto eliminado exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<Domain.Entities.Product>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }
    }
} 