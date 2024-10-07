using AcademiaDoZe_WPF.DataAccess;
using AcademiaDoZe_WPF.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Common;
using System.Windows;
using System.Windows.Input;

namespace AcademiaDoZe_WPF.ViewModel;

public class LogradouroViewModel : ViewModelBase
{
    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public ObservableCollection<Logradouro> Logradouros { get; set; }

    private Logradouro _selectedLogradouro;

    public Logradouro SelectedLogradouro
    {
        get { return _selectedLogradouro; }
        set
        {
            _selectedLogradouro = value;
            OnPropertyChanged("SelectedLogradouro");
        }
    }

    private LogradouroRepository _repository;

    public ICommand LogradouroAdicionarCommand { get; set; }
    public ICommand LogradouroAtualizarCommand { get; set; }
    public ICommand LogradouroRemoverCommand { get; set; }

    public LogradouroViewModel()
    {
        Logradouros = new ObservableCollection<Logradouro>();
        _repository = new LogradouroRepository();

        LogradouroAdicionarCommand = new RelayCommand(AdicionarLogradouro);
        LogradouroAtualizarCommand = new RelayCommand(AtualizarLogradouro);
        LogradouroRemoverCommand = new RelayCommand(RemoverLogradouro);

        GetAll();
    }

    public void GetAll()
    {
        // busca no banco de dados e carrega em Logradouros
        Logradouros.Clear();
        _repository.GetAll().ForEach(data => Logradouros.Add(data));
    }

    private readonly DbProviderFactory factory;
    private string ConnectionString { get; set; }
    private string ProviderName { get; set; }

    public LogradouroViewModel(string providerName, string connectionString)
    {
        ConnectionString = connectionString;
        ProviderName = providerName;
        // define a factory, ou seja, o provedor de dados - Mysql, SqlServer, etc
        factory = DbProviderFactories.GetFactory(ProviderName);
        // inicializa a lista de logradouros
        Logradouros = new ObservableCollection<Logradouro>();
    }

    public void Load()
    {
        Logradouros.Clear();
        using var conexao = factory.CreateConnection(); //Cria conexão
        conexao!.ConnectionString = ConnectionString; //Atribui a string de conexão
        using var comando = factory.CreateCommand(); //Cria comando
        comando!.Connection = conexao; //Atribui conexão
        conexao.Open();
        comando.CommandText = @"SELECT id_logradouro, cep, pais, uf, cidade, bairro, logradouro FROM tb_logradouro;";
        using var reader = comando.ExecuteReader();
        // carrega os dados para ser utilizado no databinding
        while (reader.Read())
        {
            Logradouros.Add(new Logradouro
            {
                Id = reader.GetInt32(0),
                Cep = reader.GetString(1),
                Pais = reader.GetString(2),
                Uf = reader.GetString(3),
                Cidade = reader.GetString(4),
                Bairro = reader.GetString(5),
                Nome = reader.GetString(6)
            });
        }
    }

    public void Add(Logradouro dado)
    {
        using var conexao = factory.CreateConnection(); //Cria conexão
        conexao!.ConnectionString = ConnectionString; //Atribui a string de conexão
        using var comando = factory.CreateCommand(); //Cria comando
        comando!.Connection = conexao; //Atribui conexão
                                       //Adiciona parâmetro (@campo e valor)

        var cep = comando.CreateParameter();
        cep.ParameterName = "@cep";
        cep.Value = dado.Cep;
        comando.Parameters.Add(cep);
        var pais = comando.CreateParameter();
        pais.ParameterName = "@pais";
        pais.Value = dado.Pais;
        comando.Parameters.Add(pais);
        var uf = comando.CreateParameter();
        uf.ParameterName = "@uf";
        uf.Value = dado.Uf;
        comando.Parameters.Add(uf);
        var cidade = comando.CreateParameter();
        cidade.ParameterName = "@cidade";
        cidade.Value = dado.Cidade;
        comando.Parameters.Add(cidade);
        var bairro = comando.CreateParameter();
        bairro.ParameterName = "@bairro";
        bairro.Value = dado.Bairro;
        comando.Parameters.Add(bairro);
        var logradouro = comando.CreateParameter();
        logradouro.ParameterName = "@logradouro";
        logradouro.Value = dado.Nome;
        comando.Parameters.Add(logradouro);
        conexao.Open();
        comando.CommandText = @"INSERT INTO tb_logradouro (cep, pais, uf, cidade, bairro, logradouro) VALUES (@cep, @pais, @uf, @cidade, @bairro, @logradouro);";
        //Executa o script na conexão e armazena o número de linhas afetadas.
        var linhas = comando.ExecuteNonQuery();
    }

    public void Update(Logradouro dado)
    {
        using var conexao = factory.CreateConnection(); //Cria conexão
        conexao!.ConnectionString = ConnectionString; //Atribui a string de conexão
        using var comando = factory.CreateCommand(); //Cria comando
        comando!.Connection = conexao; //Atribui conexão
                                       //Adiciona parâmetro (@campo e valor)

        var id = comando.CreateParameter();
        id.ParameterName = "@id";
        id.Value = dado.Id;
        comando.Parameters.Add(id);
        var cep = comando.CreateParameter();
        cep.ParameterName = "@cep";
        cep.Value = dado.Cep;
        comando.Parameters.Add(cep);
        var pais = comando.CreateParameter();
        pais.ParameterName = "@pais";
        pais.Value = dado.Pais;
        comando.Parameters.Add(pais);
        var uf = comando.CreateParameter();
        uf.ParameterName = "@uf";
        uf.Value = dado.Uf;
        comando.Parameters.Add(uf);
        var cidade = comando.CreateParameter();
        cidade.ParameterName = "@cidade";
        cidade.Value = dado.Cidade;
        comando.Parameters.Add(cidade);
        var bairro = comando.CreateParameter();
        bairro.ParameterName = "@bairro";
        bairro.Value = dado.Bairro;
        comando.Parameters.Add(bairro);
        var logradouro = comando.CreateParameter();
        logradouro.ParameterName = "@logradouro";
        logradouro.Value = dado.Nome;
        comando.Parameters.Add(logradouro);
        conexao.Open();
        comando.CommandText = @"UPDATE tb_logradouro SET cep = @cep, pais = @pais, uf = @uf, cidade = @cidade, bairro = @bairro, logradouro = @logradouro WHERE id_logradouro = @id;";
        //executa o comando no banco de dados
        _ = comando.ExecuteNonQuery();
    }

    public void Delete(Logradouro dado)
    {
        using var conexao = factory.CreateConnection(); //Cria conexão
        conexao!.ConnectionString = ConnectionString; //Atribui a string de conexão
        using var comando = factory.CreateCommand(); //Cria comando
        comando!.Connection = conexao; //Atribui conexão
                                       //Adiciona parâmetro (@campo e valor)
        var id = comando.CreateParameter();
        id.ParameterName = "@id";
        id.Value = dado.Id;
        comando.Parameters.Add(id);
        conexao.Open();
        //realiza o DELETE
        comando.CommandText = @"DELETE FROM tb_logradouro WHERE id_logradouro = @id;";
        //executa o comando no banco de dados
        _ = comando.ExecuteNonQuery();
    }

    private void AdicionarLogradouro(object obj)
    {
        if (SelectedLogradouro == null) return;
        if (MessageBox.Show("Confirma?", "Logradouro", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
        {
            try
            {
                _repository.Add(SelectedLogradouro);
                MessageBox.Show("Sucesso.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                GetAll();
            }
        }
    }

    private void AtualizarLogradouro(object obj)
    {
        if (SelectedLogradouro == null) return;
        if (MessageBox.Show("Confirma?", "Logradouro", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
        {
            try
            {
                _repository.Update(SelectedLogradouro);

                MessageBox.Show("Sucesso.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                GetAll();
            }
        }
    }

    private void RemoverLogradouro(object obj)
    {
        if (SelectedLogradouro == null) 
            return;

        if (MessageBox.Show("Confirma?", "Logradouro", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
        {
            try
            {
                _repository.Delete(SelectedLogradouro);
                MessageBox.Show("Sucesso.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                GetAll();
            }
        }
    }
}