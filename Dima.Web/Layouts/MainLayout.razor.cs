using MudBlazor;

namespace Dima.Web.Layouts
{
    public partial class MainLayout 
    {
        public class FilterModel
        {
            public string StartDate { get; set; }
            public string Object { get; set; }
            public string Year { get; set; }
        }
        private void Search()
        {
            // Implement search logic here...
        }
        private FilterModel filter = new FilterModel();
        private void ClearFilters()
        {
            filter = new FilterModel();
        }
        private Documento? selectedDocument;
        private bool drawerOpen = false;

        private void ToggleDocument(TableRowClickEventArgs<Documento> document)
        {
            // Se o documento selecionado for o mesmo, ocultamos o MudCard
            if (selectedDocument == document.Item)
            {
                selectedDocument = null; // Ocultar MudCard
            }
            else
            {
                selectedDocument = document.Item; // Mostrar MudCard
            }
        }
        // Controle do Drawer de navegação (menu lateral)
        private bool _isMenuDrawerOpened = true;
        // Controle do Drawer de configurações
        private bool _isConfigDrawerOpened = false;
        // Controle do Drawer de informações do usuário
        private bool _isUserDrawerOpened = false;

        // Controle do modo Dark/Light
        private bool _isDarkMode = true;

        private MudThemeProvider _mudThemeProvider = null!;
        private Breakpoint _breakpoint = Breakpoint.Sm;
        private DrawerClipMode _clipModeMenu = DrawerClipMode.Always;
        private string _searchTerm;

        public class Documento
        {
            public string Nome { get; set; }
            public int Total { get; set; }
        }

        // Exemplo de lista de documentos
        public List<Documento> documentos = new List<Documento>();

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
        private void ToggleConfigDrawer()
        {
            _isConfigDrawerOpened = !_isConfigDrawerOpened;
        }

        private Task OnSystemPreferenceChanged(bool newValue)
        {
            _isDarkMode = newValue;
            StateHasChanged();
            return Task.CompletedTask;
        }

        // Método para alternar o Drawer de navegação (menu lateral)
        private void ToggleMenuDrawer()
        {
            _isMenuDrawerOpened = !_isMenuDrawerOpened;
        }

        // Método para alternar o Drawer de informações do usuário
        private void ToggleUserDrawer()
        {
            _isUserDrawerOpened = !_isUserDrawerOpened;
        }

        // Método para carregar os documentos ao clicar em "Acervo"
        private void LoadDocuments()
        {
            // Adicione a lógica de carregamento de documentos aqui.
            // Pode ser uma chamada de API ou uma consulta ao banco de dados.
            documentos = new List<Documento>
        {
            new Documento { Nome = "ATA", Total = 406 },
            new Documento { Nome = "Contrato", Total = 15 },
            new Documento { Nome = "Contrato AB", Total = 2 },
            new Documento { Nome = "Contrato de Locação de Equipamentos", Total = 1 },
            new Documento { Nome = "Teste", Total = 1 },
            new Documento { Nome = "ATA", Total = 406 },
            new Documento { Nome = "Contrato", Total = 15 },
            new Documento { Nome = "Contrato AB", Total = 2 },
            new Documento { Nome = "Contrato de Locação de Equipamentos", Total = 1 },
            new Documento { Nome = "Teste", Total = 1 },
            new Documento { Nome = "ATA", Total = 406 },
            new Documento { Nome = "Contrato", Total = 15 },
            new Documento { Nome = "Contrato AB", Total = 2 },
            new Documento { Nome = "Contrato de Locação de Equipamentos", Total = 1 },
            new Documento { Nome = "Teste", Total = 1 },
            // Outros documentos...
        };

            StateHasChanged();
        }
    }
}
