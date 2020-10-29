using System;
using System.Collections.Generic;
using System.Text;

namespace Zadaca
{
    public class Episode
    {
        public int viewers;
        public double sum_of_scores;
        public double max_score;
        public double average_score;

        public Episode() : this(0, 0, 0) { }
        public Episode(int aViewers, double aSum_of_scores, double aMax_score)
        {
            this.viewers = aViewers;
            this.sum_of_scores = aSum_of_scores;
            this.max_score = aMax_score;
            average_score = sum_of_scores / viewers;
        }

        public double GetViewerCount()
        {
            return viewers;
        }
        public double GetMaxScore()
        {
            return max_score;
        }
        public double GetAverageScore()
        {
            return sum_of_scores / viewers;
        }

        public void AddView(double x)
        {
            viewers++;
            if (x > max_score) max_score = x;
            sum_of_scores += x;
            average_score = GetAverageScore();
        }
    }
}