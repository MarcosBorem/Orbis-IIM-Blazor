using MudBlazor;

namespace orbis.iim.web.Layouts
{
    public partial class MainLayout
    {
        #region Properties

        public Documento? selectedDocument;

        public bool drawerOpen = false;

        // Controle do Drawer de navegação (menu lateral)
        public bool _isMenuDrawerOpened = true;

        // Controle do Drawer de configurações
        public bool _isConfigDrawerOpened = false;

        // Controle do Drawer de informações do usuário
        public bool _isUserDrawerOpened = false;

        // Controle do modo Dark/Light
        public bool _isDarkMode = true;
        
        public MudThemeProvider _mudThemeProvider = null!;

        public Breakpoint _breakpoint = Breakpoint.Sm;

        public DrawerClipMode _clipModeMenu = DrawerClipMode.Always;

        public string _searchTerm = string.Empty;

        public List<Documento> documentos = new List<Documento>();

        public FilterModel filter = new FilterModel();
        #endregion

        #region Methods

        public void Search()
        {
            // Implement search logic here...
        }

        public void ClearFilters()
        {
            filter = new FilterModel();
        }

        public void ToggleDocument(Documento document)
        {
            if (selectedDocument == document)
            {
                selectedDocument = null; // Ocultar MudCard
            }
            else
            {
                selectedDocument = document; // Mostrar MudCard
            }
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                _isDarkMode = await _mudThemeProvider.GetSystemPreference();
                await _mudThemeProvider.WatchSystemPreference(OnSystemPreferenceChanged);
                LoadDocuments();
                StateHasChanged();
            }
        }
        // Método para alternar o Drawer de configurações
        public void ToggleConfigDrawer()
        {
            _isConfigDrawerOpened = !_isConfigDrawerOpened;
        }

        public Task OnSystemPreferenceChanged(bool newValue)
        {
            _isDarkMode = newValue;
            StateHasChanged();
            return Task.CompletedTask;
        }

        // Método para alternar o Drawer de navegação (menu lateral)
        public void ToggleMenuDrawer()
        {
            _isMenuDrawerOpened = !_isMenuDrawerOpened;
        }

        // Método para alternar o Drawer de informações do usuário
        public void ToggleUserDrawer()
        {
            _isUserDrawerOpened = !_isUserDrawerOpened;
        }

        // Método para carregar os documentos ao clicar em "Acervo"
        public void LoadDocuments()
        {
            documentos = new List<Documento>
            {
            new Documento { Id = 2, Nome = "Contrato", Total = 15 },
            new Documento { Id = 3, Nome = "Contrato AB", Total = 2 },
            new Documento { Id = 4, Nome = "Contrato de Locação de Equipamentos", Total = 1 },
            new Documento { Id = 5, Nome = "Teste", Total = 1 },
            new Documento { Id = 6, Nome = "ATA", Total = 406 },
            new Documento { Id = 7, Nome = "Contrato", Total = 15 },
            new Documento { Id = 8, Nome = "Contrato AB", Total = 2 },
            new Documento { Id = 9, Nome = "Contrato de Locação de Equipamentos", Total = 1 },
            new Documento { Id = 10, Nome = "Teste", Total = 1 },
            };

            StateHasChanged();
        }

        public void PerformSearch(string searchTerm)
        {
            // Ação a ser realizada ao clicar no ícone de pesquisa
            Console.WriteLine($"Pesquisando por: {searchTerm}");
            _searchTerm = searchTerm;
        }

        #endregion
        public class FilterModel
        {
            public string StartDate { get; set; } = string.Empty;
            public string Object { get; set; } = string.Empty;
            public string Year { get; set; } = string.Empty;
        }

        public class Documento
        {
            public int Id { get; set; }
            public string? Nome { get; set; }
            public int Total { get; set; }
        }
    }
}
