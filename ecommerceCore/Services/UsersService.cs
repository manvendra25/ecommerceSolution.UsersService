using AutoMapper;
using ecommerceCore.DTO;
using ecommerceCore.Entities;
using ecommerceCore.RepositoryContracts;
using ecommerceCore.ServiceContracts;


namespace ecommerceCore.Services
{
    internal class UsersService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;
        private readonly IMapper _mapper;

        public UsersService(IUsersRepository usersRepository, IMapper mapper)
        {
            _usersRepository = usersRepository;
            _mapper = mapper;
        }


        public async Task<AuthenticationResponse?> Login(LoginRequest loginRequest)
        {
            ApplicationUser? user = await _usersRepository.GetUserByEmailAndPassword(loginRequest.Email, loginRequest.Password);

            if (user == null)
            {
                return null;
            }
            return _mapper.Map<AuthenticationResponse>(user) with { Success = true, Token = "token" };
        }


        public async Task<AuthenticationResponse?> Register(RegisterRequest registerRequest)
        {
            ApplicationUser user = _mapper.Map<ApplicationUser>(registerRequest);
            ApplicationUser? registeredUser = await _usersRepository.AddUser(user);
            if (registeredUser == null)
            {
                return null;
            }
            return _mapper.Map<AuthenticationResponse>(registeredUser) with { Success = true, Token = "token" };
        }
    }
    }
