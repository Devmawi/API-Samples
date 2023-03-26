using GraphQLFeatures.Models;
using HotChocolate.Execution;
using HotChocolate.Subscriptions;

namespace GraphQLFeatures.GraphQL
{
    public class Subscription
    {
        [SubscribeAndResolve]
        public async ValueTask<ISourceStream<Author>>
        OnAuthorCreated([Service]
        ITopicEventReceiver eventReceiver,
            CancellationToken cancellationToken)
        {
            return await eventReceiver.SubscribeAsync
            <Author>("AuthorCreated",
            cancellationToken);
        }

        [Subscribe]
        public Author AuthorAdded([EventMessage] Author author){
          
            return author;
        }

        [SubscribeAndResolve]
        public async ValueTask<ISourceStream
        <List<Author>>> OnAuthorsGet([Service]
        ITopicEventReceiver eventReceiver,
           CancellationToken cancellationToken)
        {
            return await eventReceiver.SubscribeAsync<
            List<Author>>("ReturnedAuthors",
            cancellationToken);
        }
        [SubscribeAndResolve]
        public async ValueTask<ISourceStream<Author>>
        OnAuthorGet([Service] ITopicEventReceiver
        eventReceiver, CancellationToken cancellationToken)
        {
            return await eventReceiver.SubscribeAsync<
            Author>("ReturnedAuthor", cancellationToken);
        }
        [SubscribeAndResolve]
        public async ValueTask<ISourceStream<BlogPost>>
        OnBlogPostsGet([Service] ITopicEventReceiver
        eventReceiver, CancellationToken cancellationToken)
        {
            return await eventReceiver.SubscribeAsync<
            BlogPost>("ReturnedBlogPosts", cancellationToken);
        }
        [SubscribeAndResolve]
        public async ValueTask<ISourceStream<BlogPost>>
        OnBlogPostGet([Service] ITopicEventReceiver
        eventReceiver, CancellationToken cancellationToken)
        {
            return await eventReceiver.SubscribeAsync<
            BlogPost>("ReturnedBlogPost", cancellationToken);
        }
    }
}
