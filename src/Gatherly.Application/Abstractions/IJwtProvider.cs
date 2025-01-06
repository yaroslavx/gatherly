using Gatherly.Domain.Entities;

public interface IJwtProvider
{
    string Generate(Member member);
}