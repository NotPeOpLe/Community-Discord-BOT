namespace CommunityBot.Features.Economy
{
    public interface IMiuniesTransfer
    {
        void UserToUser(ulong sourceUserId, ulong targetUserId, ulong amount);
    }
}