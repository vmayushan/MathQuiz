﻿using System.Threading.Tasks;
using MathQuiz.AppLayer.Services.Dto;

namespace MathQuiz.AppLayer.Services
{
    public interface IQuizService
    {
        Task HandleUserAnswer(string username, bool answer);

        Task<(string, QuizDto)> GetUserQuizWithId(string username);

        Task<QuizDto> StartQuiz(string username);

        Task ExitQuiz(string username);

        Task SetChallengeToQuiz(string quizId, string question, bool isCorrect);
    }
}