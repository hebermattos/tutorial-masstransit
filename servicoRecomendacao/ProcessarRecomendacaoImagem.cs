using System;
using System.Threading;
using System.Threading.Tasks;
using core;
using MassTransit;

namespace servico
{
    public class ProcessarRecomendacaoImagem : IConsumer<VisualicaoImagem>
    {
        public Task Consume(ConsumeContext<VisualicaoImagem> context)
        {
            AtualizarRecomendacoes(context.Message.IdImagem);

            EnviarNotificacoes(context.Message.IdImagem);

            return Task.CompletedTask;
        }

        private void AtualizarRecomendacoes(string id)
        {
            Console.WriteLine("Atualizou Recomendacoes:" + id);
            return;
        }

        private void EnviarNotificacoes(string id)
        {
            Console.WriteLine("Enviou Notificacoes:" + id);
            return;
        }
    }
}