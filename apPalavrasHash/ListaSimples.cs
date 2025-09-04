using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// ListaSimples fornecida pelo professor
public class ListaSimples<Dado>
             where Dado : IComparable<Dado>
{
    NoLista<Dado> primeiro, ultimo, anterior, atual;
    int quantosNos;
    bool primeiroAcessoDoPercurso;

    public int ContarNos()
    {
        int contador = 0;
        atual = primeiro;
        while (atual != null)
        {
            contador++;
            atual = atual.Prox;
        }
        return contador;
    }

    public ListaSimples<Dado> Juntar(ListaSimples<Dado> l2)
    {
        var lista3 = new ListaSimples<Dado>();
        this.atual = this.primeiro;
        l2.atual = l2.primeiro;
        while (this.atual != null && l2.atual != null)
            if (this.atual.Info.CompareTo(l2.atual.Info) < 0)
            {
                lista3.InserirAposFim(this.atual.Info);
                this.atual = this.atual.Prox;
            }
            else
              if (l2.atual.Info.CompareTo(this.atual.Info) < 0)
            {
                lista3.InserirAposFim(l2.atual.Info);
                l2.atual = l2.atual.Prox;
            }
            else
            {
                lista3.InserirAposFim(this.atual.Info);
                this.atual = this.atual.Prox;
                l2.atual = l2.atual.Prox;
            }

        while (this.atual != null)
        {
            lista3.InserirAposFim(this.atual.Info);
            this.atual = this.atual.Prox;
        }

        while (l2.atual != null)
        {
            lista3.InserirAposFim(l2.atual.Info);
            l2.atual = l2.atual.Prox;
        }

        return lista3;

    }

    public void Inverter()
    {
        if (!EstaVazia)
        {
            var um = primeiro;
            var dois = primeiro.Prox;
            while (dois != null)
            {
                var tres = dois.Prox;
                dois.Prox = um;
                um = dois;
                dois = tres;
            }
            ultimo = primeiro;
            primeiro.Prox = null;
            primeiro = um;
        }
    }
    public void Listar(ListBox lsb)
    {
        lsb.Items.Clear();
        atual = primeiro;    
        while (atual != null) 
        {
            lsb.Items.Add(atual.Info);  
            atual = atual.Prox;         
        }
    }

    public ListaSimples()
    {
        primeiro = ultimo = anterior = atual = null;
        quantosNos = 0;
        primeiroAcessoDoPercurso = false;
    }

    public void PercorrerLista()
    {
        atual = primeiro;
        while (atual != null)
        {
            Console.WriteLine(atual.Info);
            atual = atual.Prox;
        }
    }
    public bool EstaVazia
    {
        get => primeiro == null;
    }
    public NoLista<Dado> Primeiro
    {
        get => primeiro;
    }
    public NoLista<Dado> Ultimo
    {
        get => ultimo;
    }
    public int QuantosNos
    {
        get => quantosNos;
    }

    public void InserirAntesDoInicio(Dado novoDado)
    {
        var novoNo = new NoLista<Dado>(novoDado);

        if (EstaVazia)
            ultimo = novoNo;

        novoNo.Prox = primeiro;
        primeiro = novoNo;
        quantosNos++;
    }

    public void InserirAposFim(Dado novoDado)
    {
        var novoNo = new NoLista<Dado>(novoDado);

        if (EstaVazia)
            primeiro = novoNo;
        else
            ultimo.Prox = novoNo;

        ultimo = novoNo;
        quantosNos++;
    }

    public void InserirAposFim(NoLista<Dado> noExistente)
    {
        if (noExistente != null)
        {
            if (EstaVazia)
                primeiro = noExistente;
            else
                ultimo.Prox = noExistente;

            ultimo = noExistente;
            noExistente.Prox = null;
            quantosNos++;
        }
    }

    public bool Existe(Dado outroProcurado)
    {
        anterior = null;
        atual = primeiro;

        if (EstaVazia)
            return false;

        if (outroProcurado.CompareTo(primeiro.Info) < 0)
            return false;

        if (outroProcurado.CompareTo(ultimo.Info) > 0)
        {
            anterior = ultimo;
            atual = null;
            return false;
        }

        bool achou = false;
        bool fim = false;

        while (!achou && !fim)
            if (atual == null)
                fim = true;
            else
              if (outroProcurado.CompareTo(atual.Info) == 0)
                achou = true;
            else
                if (atual.Info.CompareTo(outroProcurado) > 0)
                fim = true;
            else
            {
                anterior = atual;
                atual = atual.Prox;
            }

        return achou;   
    }

    public NoLista<Dado> Atual => atual;

    public void InserirEmOrdem(Dado dados)
    {
        if (!Existe(dados))     
        {                       
            if (EstaVazia)        	
                InserirAntesDoInicio(dados); 
            else
               
               if (anterior == null && atual != null)
                InserirAntesDoInicio(dados); 
            else
                 if (anterior != null && atual == null)
                InserirAposFim(dados);
            else
                InserirNoMeio(dados);  
        }
    }

    private void InserirNoMeio(Dado dados)
    {
        
        var novo = new NoLista<Dado>(dados);
        anterior.Prox = novo;   
        novo.Prox = atual;      

        if (anterior == ultimo)  
            ultimo = novo;        
        quantosNos++;            // 	}	
    }





}
