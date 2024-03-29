﻿using System;
using System.Collections.Generic;

namespace MazeDijkstra
{
    class Graph
    {
        int[,] adj = new int[6, 6]
        {
            { -1, 15, -1, 35, -1, -1 },
            { 15, -1, 05, 10, -1, -1 },
            { -1, 05, -1, -1, -1, -1 },
            { 35, 10, -1, -1, 05, -1 },
            { -1, -1, -1, 05, -1, 05 },
            { -1, -1, -1, -1, 05, -1 },
        };

        public void Dijikstra(int start)
        {
            bool[] visited = new bool[6];
            int[] distance = new int[6];
            int[] parent = new int[6];

            Array.Fill(distance, Int32.MaxValue);

            distance[start] = 0;
            parent[start] = start;

            while (true)
            {
                // 제일 좋은 후보를 찾는다 (가장 가까이에 있는)

                // 가장 유력한 후보의 거리와 번호 저장
                int closest = Int32.MaxValue;
                int now = -1;
                for (int i = 0; i < 6; i++)
                {
                    // 이미 방문한 정점 스킵
                    if (visited[i])
                        continue;

                    // 아직 발견된 적이 없거나, 기존 후보보다 멀리 있으면 스킵
                    if (distance[i] == Int32.MaxValue || distance[i] >= closest)
                        continue;

                    // 여태껏 발견한 가장 좋은 후보라는 의미니까, 정보를 갱신
                    closest = distance[i];
                    now = i;
                }

                // 다음 후보가 하나도 없다 -> 종료
                if (now == -1)
                    break;

                // 제일 좋은 후보를 찾았으니까 방문한다.
                visited[now] = true;

                // 방문한 정점과 인접한 정점들을 조사해서,
                // 상황에 따라 발견한 최단거리를 갱신한다.
                for (int next = 0; next < 6; next++)
                {
                    // 연결되지 않은 정점 스킵
                    if (adj[now, next] == -1)
                        continue;
                    // 이미 방문한 정점은 스킵
                    if (visited[next])
                        continue;

                    // 새로 조사된 정점의 최단거리를 계산한다.
                    int nextDist = distance[now] + adj[now, next];
                    // 만약에 기존에 발견한 최단거리가 새로 조사된 최단거리보다 크면, 정보를 갱신
                    if (nextDist < distance[next])
                    {
                        distance[next] = nextDist;
                        parent[next] = now;
                    }
                }
            }
        }


        public void BFS(int start)
        {
            bool[] found = new bool[6];
            int[] parent = new int[6];
            int[] distance = new int[6];

            Queue<int> q = new Queue<int>();
            q.Enqueue(start);
            found[start] = true;
            parent[start] = start;
            distance[start] = 0;

            while (q.Count > 0)
            {
                int now = q.Dequeue();
                Console.WriteLine(now);

                for (int next = 0; next < 6; next++)
                {
                    if (adj[now, next] == 0)    // 인접하지 않았으면 스킵
                        continue;
                    if (found[next])    // 이미 발견한 애라면 스킵
                        continue;
                    q.Enqueue(next);
                    found[next] = true;
                    parent[next] = now;
                    distance[next] = distance[now] + 1;
                }
            }
        }

        // 1) 우선 now부터 방문하고,
        // 2) now와 연결된 정점들을 하나씩 확인해서, 아직 미발견(미방문) 상태라면 방문한다.
        public void DFS(int now, bool[] visited)
        {
            Console.WriteLine(now);
            visited[now] = true; // 1) 우선 now부터 방문하고,
            adj.GetLength(0);

            for (int next = 0; next < 6; next++)
            {
                if (adj[now, next] == 0)    // 연결되어 있지 않으면 스킵.
                    continue;
                if (visited[next])      // 이미 방문했으면 스킵
                    continue;
                DFS(next, visited);
            }
        }

        // 2) now와 연결된 정점들을 하나씩 확인해서, 아직 미발견(미방문) 상태라면 방문한다.
        //public void DFS2(int now, bool[] visited)
        //{
        //    Console.WriteLine(now);
        //    visited[now] = true; // 1) 우선 now부터 방문하고,

        //    foreach (int next in adj2[now])
        //    {
        //        if (visited[next])      // 이미 방문했으면 스킵
        //            continue;
        //        DFS2(next, visited);
        //    }

        //}

        public void SearchAll()
        {
            bool[] visited = new bool[6];
            for (int now = 0; now < 6; now++)
                if (visited[now] = false)
                    DFS(now, visited);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // DFS (Depth First Search 깊이 우선 탐색)
            // BFS (Breadth First Search 너비 우선 탐색)
            Graph graph = new Graph();
            graph.Dijikstra(0);
            //graph.SearchAll();

        }
    }
}
